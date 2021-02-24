using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarApp
{
    public partial class FurnitorView : Form
    {
       
        //public Furnitor selectedFurnitor = new Furnitor();
        
        public FurnitorView()
        {
            InitializeComponent();
        }
        

        private void FurnitorView_Load(object sender, EventArgs e)
        {
            //loggedPerdorues = loggedPerdorues.getLoggedPerdorues(Login.username);
            //dataGridViewFurnitorList.DataSource = listFurnitoresh();
        }

        private void dataGridViewFurnitorList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            //selectedFurnitor.id = Convert.ToInt32(dataGridViewFurnitorList.Rows[rowIndex].Cells[0].Value.ToString());
            //selectedFurnitor.emer = dataGridViewFurnitorList.Rows[rowIndex].Cells[1].Value.ToString();
            //selectedFurnitor.nrTel = dataGridViewFurnitorList.Rows[rowIndex].Cells[5].Value.ToString();
            //selectedFurnitor.email = dataGridViewFurnitorList.Rows[rowIndex].Cells[6].Value.ToString();
            //textBoxID.Text = selectedFurnitor.id.ToString();
            //textBoxEmer.Text = selectedFurnitor.emer;
            //textBoxNrTel.Text = selectedFurnitor.nrTel;
            //textBoxEmail.Text = selectedFurnitor.email;
        }
        
        private void textBoxKerko_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxKerko.Text;
            //dataGridViewFurnitorList.DataSource = loggedPerdorues.KerkoFurnitor(keyword, loggedPerdorues.id);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxKerko.Text = "";
           // dataGridViewFurnitorList.DataSource = listFurnitoresh();

        }
    }
}
