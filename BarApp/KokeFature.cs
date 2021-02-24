using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarApp
{
    class KokeFature
    {
        public int id { get; set; }
        public DateTime data { get; set; }
        public int status { get; set; }
        public string nrFature { get; set; }
        public Tavolina t { get; set; }
        public Perdorues kamarier { get; set; }


        public KokeFature()
        {
            t = new Tavolina();
            kamarier = new Perdorues();
        }

        internal bool shtoKokeFature(KokeFature kf)
        {
            bool isSuccess = false;
            using (SqlConnection conn = Connection.GetConnection())
            {
                string query = @"INSERT INTO [dbo].[koke_furnizimi]
                                (
                                [Id],
                                [Id_tavolina],
                                [Data],
                                [Id_kamarier],
                                [Status],
                                [Nr_fature],
                            VALUES
                                (
                                 @Id_tavolina,
                                 @Data,
                                 @Id_kamarier,
                                 @Status,
                                 @Nr_fature
                                )";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id_tavolina", kf.t.id);
                    cmd.Parameters.AddWithValue("@Data", kf.data);
                    cmd.Parameters.AddWithValue("@Nr_fature", kf.nrFature);
                    cmd.Parameters.AddWithValue("@Status", kf.nrFature);
                    cmd.Parameters.AddWithValue("@Id_kamarier", kf.kamarier.id);
                    conn.Open();
                    isSuccess = cmd.ExecuteNonQuery() > 0 ? true : false;
                    conn.Close();
                }
            }
            return isSuccess;
        }


        internal bool ndryshoKokeFature(KokeFature kf)
        {
            bool isSuccess = false;
            using (SqlConnection conn = Connection.GetConnection())
            {
                string query = @"UPDATE [dbo].[koke_fature]
                               SET [Id_tavolina] = @Id_tavolina,
                                [Data] = @Data,
                                [Id_kamarier] = @Id_kamarier,
                                [Status] = @Status,
                                [Nr_fature] = @Nr_fature
                             WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id_tavolina", kf.t.id);
                    cmd.Parameters.AddWithValue("@Data", kf.data);
                    cmd.Parameters.AddWithValue("@Nr_fature", kf.nrFature);
                    cmd.Parameters.AddWithValue("@Status", kf.nrFature);
                    cmd.Parameters.AddWithValue("@Id_kamarier", kf.kamarier.id);
                    conn.Open();
                    isSuccess = cmd.ExecuteNonQuery() > 0 ? true : false;
                    conn.Close();
                }
                return isSuccess;
            }
        }


        internal DataTable SelectKokeFature()
        {
            using (SqlConnection con = Connection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spListeKokeFature", con))
                {
                    DataTable listeKokeFature = new DataTable();
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(listeKokeFature);
                    return listeKokeFature;
                }
            }
        }


        public DataTable KerkoKokeFature(string keyword)
        {
            DataTable rez = new DataTable();
            using (SqlConnection conn = Connection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spKerkoKokeFature", conn))
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
