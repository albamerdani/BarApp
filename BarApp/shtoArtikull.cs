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
    public partial class shtoArtikull : Form
    {
        Artikull artikull = new Artikull();
        Helper h = new Helper();

        public shtoArtikull()
        {
            InitializeComponent();
        }


        private void shtoArtikull_Load(object sender, EventArgs e)
        {
            //load artikujt ekzistues
            dataGridViewArtikullList.DataSource = artikull.SelectArtikull();

            string getKategoriQuery = "SELECT [Id],[Kategoria] FROM[dbo].[Kategori] WHERE [Status] = 1";
            h.fillComboBox1(comboBoxKategori, getKategoriQuery, "Kategoria", "Id");

            string getNjesiQuery = "SELECT [Id],[lloji] FROM[dbo].[Njesi_matese]";
            h.fillComboBox1(comboBoxNjesia, getNjesiQuery, "lloji", "Id");

            buttonShtoArtikull.Enabled = true;
            buttonNdryshoArtikull.Enabled = false;
            buttonClear.Enabled = false;

        }


        private void buttonShtoArtikull_Click(object sender, EventArgs e)
        {
            artikull.artikull = textBoxArtikulli.Text;
            artikull.sasia = Convert.ToInt32(textBoxSasia.Text);
            artikull.cmimi = Convert.ToInt32(textBoxCmimi.Text);
            artikull.kategori.id = (int)comboBoxKategori.SelectedValue;
            artikull.njesi.id = (int)comboBoxNjesia.SelectedValue;

            if (active.Checked)
            {
                artikull.status = 1;
            }
            else if (nonActive.Checked)
            {
                artikull.status = 0;
            }

            bool success = artikull.shtoArtikull(artikull);
            if (success)
            {
                MessageBox.Show("Shtimi i artikullit te ri u krye me sukses!");
                this.Clear();
                DataTable artikullData = artikull.SelectArtikull();
                dataGridViewArtikullList.DataSource = artikullData;
            }
            else
            {
                MessageBox.Show("Shtimi i artikullit te ri deshtoi!");
            }


        }

        public void Clear()
        {
            buttonShtoArtikull.Enabled = true;
            buttonNdryshoArtikull.Enabled = false;
            buttonClear.Enabled = false;

            string getKategoriQuery = "SELECT [Id],[Kategoria] FROM[dbo].[Kategori] WHERE [Status] = 1";
            h.fillComboBox1(comboBoxKategori, getKategoriQuery, "Kategoria", "Id");

            string getNjesiQuery = "SELECT [Id],[lloji] FROM[dbo].[Njesi_matese]";
            h.fillComboBox1(comboBoxNjesia, getNjesiQuery, "lloji", "Id");

            textBoxID.Text = "";
        }
      

        private void buttonNdryshoArtikull_Click(object sender, EventArgs e)
        {
            artikull.cmimi = Convert.ToInt32(textBoxCmimi.Text);
            artikull.kategori.id = (int)comboBoxKategori.SelectedValue;
            if (active.Checked)
            {
                artikull.status = 1;
            }
            else if (nonActive.Checked)
            {
                artikull.status = 0;
            }

            if (artikull.ndryshoArtikull(artikull))
            {
                MessageBox.Show("Te dhenat e vizites u modifikuan me sukses!");
                this.Clear();
                DataTable viziteData = artikull.SelectArtikull();
                dataGridViewArtikullList.DataSource = viziteData;
            }
            else
            {
                MessageBox.Show("Gabim! Te dhenat e vizites nuk u modifikuan!");
            }
        }

        private void dataGridViewArtikullList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            buttonShtoArtikull.Enabled = false;
            buttonNdryshoArtikull.Enabled = true;
            buttonClear.Enabled = true;
            int rowIndex = e.RowIndex;

            textBoxID.Text = dataGridViewArtikullList.Rows[rowIndex].Cells[0].Value.ToString();
            textBoxArtikulli.Text = dataGridViewArtikullList.Rows[rowIndex].Cells[1].Value.ToString();
            textBoxSasia.Text = dataGridViewArtikullList.Rows[rowIndex].Cells[2].Value.ToString();
            textBoxCmimi.Text = dataGridViewArtikullList.Rows[rowIndex].Cells[3].Value.ToString();
            comboBoxKategori.Text = dataGridViewArtikullList.Rows[rowIndex].Cells[4].Value.ToString();
            comboBoxNjesia.Text = dataGridViewArtikullList.Rows[rowIndex].Cells[5].Value.ToString();
            active.Text = dataGridViewArtikullList.Rows[rowIndex].Cells[6].Value.ToString();
        }


        private void textBoxKerko_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxKerko.Text;
            dataGridViewArtikullList.DataSource = artikull.KerkoArtikull(keyword);
            if (keyword == "")
            {
                DataTable viziteData = artikull.SelectArtikull();
                dataGridViewArtikullList.DataSource = viziteData;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

    }
}
