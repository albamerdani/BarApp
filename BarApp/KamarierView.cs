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
    public partial class KamarierView : Form
    {

       
        //public  Perdorues kamarier = new Perdorues();

        public KamarierView()
        {
            InitializeComponent();
        }

        private void KamarierView_Load(object sender, EventArgs e)
        {
          
           // dataGridViewKamarierList.DataSource = listKamarieresh();
        }

        private void dataGridViewFurnitorList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
           // kamarier.id = Convert.ToInt32(dataGridViewKamarierList.Rows[rowIndex].Cells[0].Value.ToString());
            //kamarier.emer = dataGridViewKamarierList.Rows[rowIndex].Cells[1].Value.ToString();
            //kamarier.tel = dataGridViewKamarierList.Rows[rowIndex].Cells[5].Value.ToString();
            //kamarier.gjinia = (char)dataGridViewKamarierList.Rows[rowIndex].Cells[6].Value;
            //textBoxID.Text = kamarier.id.ToString();
            //textBoxEmer.Text = kamarier.emer;
            //textBoxNrTel.Text = kamarier.tel;
            //textBoxGjinia.Text = kamarier.gjinia.ToString();
        }

        private void textBoxKerko_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxKerko.Text;
           // dataGridViewKamarierList.DataSource = KerkoKamarier(keyword);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxKerko.Text = "";
           // dataGridViewKamarierList.DataSource = listKamarieresh();

        }
    }
}
