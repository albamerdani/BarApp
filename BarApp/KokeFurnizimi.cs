using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarApp
{
    class KokeFurnizimi
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public string nr_fature{ get; set; }
        public Furnitor f { get; set; }

        public KokeFurnizimi()
        {
            f = new Furnitor();
        }

        internal bool shtoKokeFurnizimi(KokeFurnizimi kf)
        {
            bool isSuccess = false;
            using (SqlConnection conn = Connection.GetConnection())
            {
                string query = @"INSERT INTO [dbo].[koke_furnizimi]
                                (
                                [Id],
                                [Id_furnitori],
                                [Data],
                                [Nr_fature],
                            VALUES
                                (
                                 @Id_furnitori,
                                 @Data,
                                 @Nr_fature
                                )";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id_furnitori", kf.f.id);
                    cmd.Parameters.AddWithValue("@Data", kf.date);
                    cmd.Parameters.AddWithValue("@Nr_fature", kf.nr_fature);
                    conn.Open();
                    isSuccess = cmd.ExecuteNonQuery() > 0 ? true : false;
                    conn.Close();
                }
            }
            return isSuccess;
        }


        internal bool ndryshoKokeFurnizimi(KokeFurnizimi kf)
        {
            bool isSuccess = false;
            using (SqlConnection conn = Connection.GetConnection())
            {
                string query = @"UPDATE [dbo].[koke_furnizimi]
                               SET [Id_furnitori]=@Id_furnitori,
                                   [Data]=@Data,
                                   [Nr_fature]=@Nr_fature
                             WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id_furnitori", kf.f.id);
                    cmd.Parameters.AddWithValue("@Data", kf.date);
                    cmd.Parameters.AddWithValue("@Nr_fature", kf.nr_fature);
                    conn.Open();
                    isSuccess = cmd.ExecuteNonQuery() > 0 ? true : false;
                    conn.Close();
                }
                return isSuccess;
            }
        }


        internal DataTable SelectKokeFurnizimi()
        {
            using (SqlConnection con = Connection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spListeKokeFurnizimi", con))
                {
                    DataTable listeKokeFurnizimi = new DataTable();
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(listeKokeFurnizimi);
                    return listeKokeFurnizimi;
                }
            }
        }


        public DataTable KerkoKokeFurnizimi(string keyword)
        {
            DataTable rez = new DataTable();
            using (SqlConnection conn = Connection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spKerkoKokeFurnizimi", conn))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@keyword", keyword);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(rez);
                }
            }
            return rez;
        }




    }
}
