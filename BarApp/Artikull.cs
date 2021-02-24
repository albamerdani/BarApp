using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarApp
{
    class Artikull
    {
        public int id { get; set; }
        public string artikull { get; set; }
        public int sasia { get; set; }
        public int cmimi { get; set; }
        public Kategori kategori { get; set; }
        public Njesia njesi { get; set; }
        public int status { get; set; }


        public Artikull()
        {
            kategori = new Kategori();
            njesi = new Njesia();
        }


        internal bool shtoArtikull(Artikull a)
        {
            bool isSuccess = false;
            using (SqlConnection conn = Connection.GetConnection())
            {
                string query = @"INSERT INTO [dbo].[artikull]
                                (
                                [Id],
                                [Artikulli],
                                [Sasia_mbetur],
                                [Cmimi],
                                [Id_kategori],
                                [Id_njesia],
                                [Status],
                            VALUES
                                (
                                 @Artikulli,
                                 @Sasia_mbetur,
                                 @Cmimi,
                                 @Id_kategori,
                                 @Id_njesia,
                                 @Status
                                )";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Artikulli", a.artikull);
                    cmd.Parameters.AddWithValue("@Sasia_mbetur", a.sasia);
                    cmd.Parameters.AddWithValue("@Cmimi", a.cmimi);
                    cmd.Parameters.AddWithValue("@Id_kategori", a.kategori.id);
                    cmd.Parameters.AddWithValue("@Id_njesia", a.njesi.id);
                    cmd.Parameters.AddWithValue("@Status", a.status);
                    conn.Open();
                    isSuccess = cmd.ExecuteNonQuery() > 0 ? true : false;
                    conn.Close();
                }
            }
            return isSuccess;
        }


        internal bool ndryshoArtikull(Artikull a)
        {
            bool isSuccess = false;
            using (SqlConnection conn = Connection.GetConnection())
            {
                string query = @"UPDATE [dbo].[artikull]
                               SET [Cmimi] = @Cmimi,
                                   [Id_kategori] = @Id_kategori,
                                  [Status] = @Status
                             WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Cmimi", a.cmimi);
                    cmd.Parameters.AddWithValue("@Id_kategori", a.kategori.id);
                    cmd.Parameters.AddWithValue("@Status", a.status);
                    conn.Open();
                    isSuccess = cmd.ExecuteNonQuery() > 0 ? true : false;
                    conn.Close();
                }
                return isSuccess;
            }
        }


        internal DataTable SelectArtikull()
        {
            using (SqlConnection con = Connection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spListeArtikujsh", con))
                {
                    DataTable listeArtikujsh = new DataTable();
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(listeArtikujsh);
                    return listeArtikujsh;
                }
            }
        }


        public DataTable KerkoArtikull(string keyword)
        {
            DataTable rez = new DataTable();
            using (SqlConnection conn = Connection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spKerkoArtikuj", conn))
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
