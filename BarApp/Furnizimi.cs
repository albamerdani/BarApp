using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarApp
{
    class Furnizimi
    {
        public int id { get; set; }
        public int sasiBlerje { get; set; }
        public int cmimiBlerje { get; set; }
        public Artikull a { get; set; }
        public KokeFurnizimi kokeFurnizimi { get; set; }


        public Furnizimi()
        {
            kokeFurnizimi = new KokeFurnizimi();
            a = new Artikull();
        }

        internal bool shtoFurnizim(Furnizimi f)
        {
            bool isSuccess = false;
            using (SqlConnection conn = Connection.GetConnection())
            {
                string query = @"INSERT INTO [dbo].[furnizimi]
                                (
                                [Id_Artikull],
                                [Sasia],
                                [Cmimi_blerjes],
                                [Id_koke_furnizimi]
                            VALUES
                                (
                                 @Id_artikull,
                                 @Sasia,
                                 @Cmimi,
                                 @Id_koke_furnizimi
                                )";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id_artikull", f.a.id);
                    cmd.Parameters.AddWithValue("@Sasia", f.sasiBlerje);
                    cmd.Parameters.AddWithValue("@Cmimi", f.cmimiBlerje);
                    cmd.Parameters.AddWithValue("@Id_koke_fature", f.kokeFurnizimi.id);
                    conn.Open();
                    isSuccess = cmd.ExecuteNonQuery() > 0 ? true : false;
                    conn.Close();
                }
            }
            return isSuccess;
        }


        internal bool ndryshoFurnizim(Furnizimi f)
        {
            bool isSuccess = false;
            using (SqlConnection conn = Connection.GetConnection())
            {
                string query = @"UPDATE [dbo].[furnizimi]
                               SET [Id_koke_fature] = @Id_koke_fature,
                                [Id_Artikull] = @Id_artikull,
                                [Sasia] = @Sasia,
                                [Cmimi_blerjes] = @Cmimi
                             WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id_koke_fature", f.kokeFurnizimi.id);
                    cmd.Parameters.AddWithValue("@Id_artikull", f.a.id);
                    cmd.Parameters.AddWithValue("@Sasia", f.sasiBlerje);
                    cmd.Parameters.AddWithValue("@Cmimi", f.cmimiBlerje);
                    conn.Open();
                    isSuccess = cmd.ExecuteNonQuery() > 0 ? true : false;
                    conn.Close();
                }
                return isSuccess;
            }
        }


        internal DataTable SelectFurnizim()
        {
            using (SqlConnection con = Connection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spListeFurnizim", con))
                {
                    DataTable listeFurnizim = new DataTable();
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(listeFurnizim);
                    return listeFurnizim;
                }
            }
        }


        public DataTable KerkoFurnizim(string keyword)
        {
            DataTable rez = new DataTable();
            using (SqlConnection conn = Connection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spKerkoFurnizim", conn))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@keyword", keyword);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(rez);
                }
            }
            return rez;
        }

        internal bool fshiFurnizim(Furnizimi furnizimi)
        {
            bool isSuccess = false;
            using (SqlConnection conn = Connection.GetConnection())
            {
                string q = @"DELETE FROM [dbo].[furnizimi] WHERE [Id] = @ID ";
                using (SqlCommand cmd = new SqlCommand(q, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", furnizimi.id);
                    conn.Open();
                    isSuccess = cmd.ExecuteNonQuery() > 0 ? true : false;
                    conn.Close();
                }
            }
            return isSuccess;
        }
    }
}
