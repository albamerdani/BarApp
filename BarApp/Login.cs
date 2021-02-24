using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarApp
{
    public partial class Login : Form
    {
        public static string uname;

        public Login()
        {
            InitializeComponent();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            username.Clear();
            password.Clear();
            username.Focus();
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            uname = username.Text;
            //kontrollo tipin dhe hap formen perkatese per user
            
            string query = "SELECT [roli] FROM[dbo].[perdorues] WHERE username = '" + username.Text + "' AND password = '" + password.Text + "'";
            SqlConnection con = Connection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                this.Hide();
                string s = cmd.ExecuteScalar().ToString();
                switch (s)
                {
                    case "menaxher":
                        MenaxherMain mng = new MenaxherMain();
                        mng.Show();
                        break;
                    case "kamarier":
                        KamarierMain km = new KamarierMain();
                        km.Show();
                        break;
                    default:
                        MessageBox.Show("Gabim ne databaze", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                
            }
            catch
            {
                MessageBox.Show("Gabim username ose password!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}