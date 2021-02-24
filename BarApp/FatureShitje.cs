using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarApp
{
    class FatureShitje
    {
        public int id { get; set; }
        public int sasiaShitjes { get; set; }
        public int cmimiShitjes { get; set; }
        public Artikull a { get; set; }
        public KokeFature kokeFature { get; set; }

        public FatureShitje()
        {
            a = new Artikull();
            kokeFature = new KokeFature();
        }

        internal bool shtoFature(FatureShitje fsh)
        {
            bool isSuccess = false;
            using (SqlConnection conn = Connection.GetConnection())
            {
                string query = @"INSERT INTO [dbo].[fature_shitje]
                                (
                                [Id],
                                [Id_koke_fature],
                                [Id_artikull],
                                [Sasia],
                                [Cmimi]
                            VALUES
                                (
                                 @Id_koke_fature,
                                 @Id_artikull,
                                 @Sasia,
                                 @Cmimi
                                )";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id_koke_fature", fsh.kokeFature.id);
                    cmd.Parameters.AddWithValue("@Id_artikull", fsh.a.id);
                    cmd.Parameters.AddWithValue("@Sasia", fsh.sasiaShitjes);
                    cmd.Parameters.AddWithValue("@Cmimi", fsh.a.cmimi);
                    conn.Open();
                    isSuccess = cmd.ExecuteNonQuery() > 0 ? true : false;
                    conn.Close();
                }
            }
            return isSuccess;
        }


        internal bool ndryshoFature(FatureShitje fsh)
        {
            bool isSuccess = false;
            using (SqlConnection conn = Connection.GetConnection())
            {
                string query = @"UPDATE [dbo].[fature_shitje]
                               SET [Id_koke_fature] = @Id_koke_fature,
                                [Id_artikull] = @Id_artikull,
                                [Sasia] = @Sasia
                             WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id_koke_fature", fsh.kokeFature.id);
                    cmd.Parameters.AddWithValue("@Id_artikull", fsh.a.id);
                    cmd.Parameters.AddWithValue("@Sasia", fsh.sasiaShitjes);
                    conn.Open();
                    isSuccess = cmd.ExecuteNonQuery() > 0 ? true : false;
                    conn.Close();
                }
                return isSuccess;
            }
        }


        internal DataTable SelectFatureShitje()
        {
            using (SqlConnection con = Connection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spListeFature", con))
                {
                    DataTable listeFature = new DataTable();
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(listeFature);
                    return listeFature;
                }
            }
        }


        public DataTable KerkoFature(string keyword)
        {
            DataTable rez = new DataTable();
            using (SqlConnection conn = Connection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spKerkoFature", conn))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@keyword", keyword);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(rez);
                }
            }
            return rez;
        }


        internal bool fshiFature(FatureShitje fature)
        {
            bool isSuccess = false;
            using (SqlConnection conn = Connection.GetConnection())
            {
                string q = @"DELETE FROM [dbo].[fature_shitje] WHERE [Id] = @ID ";
                using (SqlCommand cmd = new SqlCommand(q, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", fature.id);
                    conn.Open();
                    isSuccess = cmd.ExecuteNonQuery() > 0 ? true : false;
                    conn.Close();
                }
            }
            return isSuccess;
        }


    }
}
