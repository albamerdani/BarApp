using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarApp
{
    class Tavolina
    {

        public int id { get; set; }
        public int status { get; set; }
        public Perdorues kamarier { get; set; }

        public Tavolina()
        {
            kamarier = new Perdorues();
        }

        internal bool shtoTavoline(Tavolina t)
        {
            bool isSuccess = false;
            using (SqlConnection conn = Connection.GetConnection())
            {
                string query = @"INSERT INTO [dbo].[tavolina]
                                (
                                [Id_kamarier],
                                [Status]
                            VALUES
                                (
                                 @Id_kamarier,
                                @Status
                                )";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id_kamarier", t.kamarier.id);
                    cmd.Parameters.AddWithValue("@Status", t.status);
                    conn.Open();
                    isSuccess = cmd.ExecuteNonQuery() > 0 ? true : false;
                    conn.Close();
                }
            }
            return isSuccess;
        }

        internal bool ndrysho(Tavolina t)
        {
            bool isSuccess = false;
            using (SqlConnection conn = Connection.GetConnection())
            {
                string query = @"UPDATE [dbo].[tavolina]
                               SET [Id_kamarier] = @Id_kamarier,
                                  [Status] = @Status
                             WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", t.id);
                    cmd.Parameters.AddWithValue("@Id_kamarier", t.kamarier.id);
                    cmd.Parameters.AddWithValue("@Status", t.status);
                    conn.Open();
                    isSuccess = cmd.ExecuteNonQuery() > 0 ? true : false;
                    conn.Close();
                }
                return isSuccess;
            }
        }

        internal DataTable SelectTavolina()
        {
            using (SqlConnection con = Connection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spListeTavolinash", con))
                {
                    DataTable listeTavolinash = new DataTable();
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(listeTavolinash);
                    return listeTavolinash;
                }
            }
        }

    }
}
