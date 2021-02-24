using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarApp
{
    class Kategori
    {
        public int id { get; set; }
        public string kategoria { get; set; }
        public int status { get; set; }

        public Kategori() { }


        internal bool shtoKategorine(Kategori k)
        {
            bool isSuccess = false;
            using (SqlConnection conn = Connection.GetConnection())
            {
                string query = @"INSERT INTO [dbo].[Kategori]
                                (
                                [Id],
                                [Kategoria],
                                [Status]
                            VALUES
                                (
                                 @kategoria,
                                 @Status
                                )";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Kategoria", k.kategoria);
                    cmd.Parameters.AddWithValue("@Status", k.status);
                    conn.Open();
                    isSuccess = cmd.ExecuteNonQuery() > 0 ? true : false;
                    conn.Close();
                }
            }
            return isSuccess;
        }


        internal bool ndryshoKategori(Kategori k)
        {
            bool isSuccess = false;
            using (SqlConnection conn = Connection.GetConnection())
            {
                string query = @"UPDATE [dbo].[Kategori]
                               SET  [Kategoria] = @Kategoria
                                    [Status] = @Status
                             WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Kategoria", k.kategoria);
                    cmd.Parameters.AddWithValue("@Status", k.status);
                    conn.Open();
                    isSuccess = cmd.ExecuteNonQuery() > 0 ? true : false;
                    conn.Close();
                }
                return isSuccess;
            }
        }


        internal DataTable SelectKategori()
        {
            using (SqlConnection con = Connection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spListeKategorish", con))
                {
                    DataTable listeKategorish = new DataTable();
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(listeKategorish);
                    return listeKategorish;
                }
            }
        }


        public DataTable KerkoKategori(string keyword)
        {
            DataTable rez = new DataTable();
            using (SqlConnection conn = Connection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spKerkoKategori", conn))
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
