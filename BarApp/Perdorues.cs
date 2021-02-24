using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarApp
{
    class Perdorues
    {

        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string roli { get; set; }
        public string status { get; set; }
        public string emer { get; set; }
        public string mbiemer { get; set; }
        public char gjinia { get; set; }
        public string tel { get; set; }
    

        internal int getIdPerdoruesByUsername(string username)
        {
            using (SqlConnection con = Connection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Id FROM Operator WHERE username = '" + username + "'", con))

                {
                    con.Open();
                    int val;
                    string s = cmd.ExecuteScalar().ToString();
                    int.TryParse(s, out val);
                    con.Close();
                    return val;
                }
            }
        }
    }
}
