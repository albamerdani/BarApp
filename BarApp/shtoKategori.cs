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
    public partial class shtoKategori : Form
    {
        Kategori k = new Kategori();

        public shtoKategori()
        {
            InitializeComponent();
        }

        private void shtoBtn_Click(object sender, EventArgs e)
        {
            k.kategoria = emertimTxtBox.Text;
            if (active.Checked)
            {
                k.status = 1;
            }
            else if (nonActive.Checked)
            {
                k.status = 0;
            }
            bool success = k.shtoKategorine(k);
            if (success)
            {
                MessageBox.Show("Shtimi i kategorise se re u krye me sukses!");
                this.Clear();
            }
            else
            {
                MessageBox.Show("Shtimi i kategorise se re deshtoi!");
            }
        }


        private void buttonNdrysho_Click(object sender, EventArgs e)
        {
            k.kategoria = emertimTxtBox.Text.ToString();
            if (active.Checked)
            {
                k.status = 1;
            }
            else if (nonActive.Checked)
            {
                k.status = 0;
            }

            if (k.ndryshoKategori(k))
            {
                MessageBox.Show("Te dhenat e kategorise u modifikuan me sukses!");
                this.Clear();
                DataTable kategoriData = k.SelectKategori();
                dataGridViewKategoriList.DataSource = kategoriData;
            }
            else
            {
                MessageBox.Show("Gabim! Te dhenat e kategorise nuk u modifikuan!");
            }
        }


        private void dataGridViewKategoriList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            shtoBtn.Enabled = false;
            buttonNdrysho.Enabled = true;
            clearBtn.Enabled = true;
            int rowIndex = e.RowIndex;

            textBoxId.Text = dataGridViewKategoriList.Rows[rowIndex].Cells[0].Value.ToString();
            emertimTxtBox.Text = dataGridViewKategoriList.Rows[rowIndex].Cells[1].Value.ToString();
            active.Text = dataGridViewKategoriList.Rows[rowIndex].Cells[2].Value.ToString();
            //nonActive.Text = dataGridViewKategoriList.Rows[rowIndex].Cells[6].Value.ToString();
        }


        private void textBoxKerko_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxKerko.Text;
            dataGridViewKategoriList.DataSource = k.KerkoKategori(keyword);
            if (keyword == "")
            {
                DataTable viziteData = k.SelectKategori();
                dataGridViewKategoriList.DataSource = viziteData;
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            this.Clear();
        }


        public void Clear()
        {
            emertimTxtBox.Clear();
        }

        private void shtoKategori_Load(object sender, EventArgs e)
        {

        }
    }
}
