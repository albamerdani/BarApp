using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarApp
{
     class Helper
    {
        public Helper()
        {
        }

        public DataTable fillComboBox(string query)
        {
            using (SqlConnection con = Connection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        sda.Fill(ds);
                        return ds.Tables[0];
                    }
                }
            }
        }

        public void fillComboBox1(System.Windows.Forms.ComboBox combo, string query, string displayMember, string valueMember)
        {
            using (SqlConnection con = Connection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        sda.Fill(table);
                        DataRow row = table.NewRow();
                        row[displayMember] = "Zgjidh--"; //insert a blank row - you can even write something lile  = "Please select bellow...";
                        table.Rows.InsertAt(row, 0); //insert new to to index 0 (on top=
                        combo.DataSource = table;
                        combo.DisplayMember = displayMember;
                        combo.ValueMember = valueMember;
                    }
                }
            }

        }
    }
}