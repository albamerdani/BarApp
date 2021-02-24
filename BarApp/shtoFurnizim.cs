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
    public partial class shtoFurnizim : Form
    {
        Helper h = new Helper();
        Furnizimi furnizimi = new Furnizimi();

        public shtoFurnizim()
        {
            InitializeComponent();
        }

        private void shtoFurnizim_Load(object sender, EventArgs e)
        {
            //load artikujt ekzistues
            dataGridViewFurnizimeList.DataSource = furnizimi.SelectFurnizim();

            string getArtikullQuery = "SELECT[Id],([Artikulli] FROM[dbo].[artikull] WHERE [Status] = 1";
            h.fillComboBox1(comboBoxArtikulli, getArtikullQuery, "Artikulli", "Id");

            string getKokeFurnizimiQuery = "SELECT [Id], [Nr_fature] FROM[dbo].[koke_furnizimi]";
            h.fillComboBox1(comboBoxFurnizimi, getKokeFurnizimiQuery, "Nr_fature", "Id");

            shtoBtn.Enabled = true;
            buttonNdrysho.Enabled = false;
            buttonFshi.Enabled = false;
            buttonPrintoFurnizim.Enabled = false;
            clearBtn.Enabled = false;
        }


        private void shtoBtn_Click(object sender, EventArgs e)
        {
            furnizimi.a.id = (int)comboBoxArtikulli.SelectedValue;
            furnizimi.sasiBlerje = Convert.ToInt32(textBoxSasi.Text);
            furnizimi.cmimiBlerje = Convert.ToInt32(textBoxCmimi.Text);
            furnizimi.kokeFurnizimi.id = (int)comboBoxFurnizimi.SelectedValue;

           
            bool success = furnizimi.shtoFurnizim(furnizimi);
            if (success)
            {
                MessageBox.Show("Shtimi i furnizimit te ri u krye me sukses!");
                this.Clear();
                DataTable fData = furnizimi.SelectFurnizim();
                dataGridViewFurnizimeList.DataSource = fData;
            }
            else
            {
                MessageBox.Show("Shtimi i furnizimit te ri deshtoi!");
            }


        }

        public void Clear()
        {
            shtoBtn.Enabled = true;
            buttonNdrysho.Enabled = false;
            buttonFshi.Enabled = false;
            buttonPrintoFurnizim.Enabled = false;
            clearBtn.Enabled = false;

            string getArtikullQuery = "SELECT[Id],([Artikulli] FROM[dbo].[artikull] WHERE [Status] = 1";
            h.fillComboBox1(comboBoxArtikulli, getArtikullQuery, "Artikulli", "Id");

            string getKokeFurnizimiQuery = "SELECT [Id], [Nr_fature] FROM[dbo].[koke_furnizimi]";
            h.fillComboBox1(comboBoxFurnizimi, getKokeFurnizimiQuery, "Nr_fature", "Id");

            textBoxId.Text = "";
        }


        private void buttonNdrysho_Click(object sender, EventArgs e)
        {
            furnizimi.a.id = (int)comboBoxArtikulli.SelectedValue;
            furnizimi.sasiBlerje = Convert.ToInt32(textBoxSasi.Text);
            furnizimi.cmimiBlerje = Convert.ToInt32(textBoxCmimi.Text);
            furnizimi.kokeFurnizimi.id = (int)comboBoxFurnizimi.SelectedValue;

            if (furnizimi.ndryshoFurnizim(furnizimi))
            {
                MessageBox.Show("Te dhenat e furnizimit u modifikuan me sukses!");
                this.Clear();
                DataTable viziteData = furnizimi.SelectFurnizim();
                dataGridViewFurnizimeList.DataSource = viziteData;
            }
            else
            {
                MessageBox.Show("Gabim! Te dhenat e furnizimit nuk u modifikuan!");
            }
        }

        private void buttonFshi_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(textBoxId.Text, out id);
            furnizimi.id = id;
            if (furnizimi.fshiFurnizim(furnizimi))
            {
                MessageBox.Show("Te dhenat e furnizimit u fshine me sukses");
                this.Clear();
                DataTable viziteData = furnizimi.SelectFurnizim();
                dataGridViewFurnizimeList.DataSource = viziteData;
            }
            else
            {
                MessageBox.Show("Gabim! Te dhenat e furnizimit nuk u fshine!");
            }
        }

        private void dataGridViewFurnizimeList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            shtoBtn.Enabled = false;
            buttonNdrysho.Enabled = true;
            buttonFshi.Enabled = true;
            buttonPrintoFurnizim.Enabled = true;
            clearBtn.Enabled = true;
            int rowIndex = e.RowIndex;

            textBoxId.Text = dataGridViewFurnizimeList.Rows[rowIndex].Cells[0].Value.ToString();
            comboBoxArtikulli.Text = dataGridViewFurnizimeList.Rows[rowIndex].Cells[1].Value.ToString();
            textBoxSasi.Text = dataGridViewFurnizimeList.Rows[rowIndex].Cells[2].Value.ToString();
            textBoxCmimi.Text = dataGridViewFurnizimeList.Rows[rowIndex].Cells[3].Value.ToString();
            comboBoxFurnizimi.Text = dataGridViewFurnizimeList.Rows[rowIndex].Cells[4].Value.ToString();
        }


        private void textBoxKerko_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxKerko.Text;
            dataGridViewFurnizimeList.DataSource = furnizimi.KerkoFurnizim(keyword);
            if (keyword == "")
            {
                DataTable fData = furnizimi.SelectFurnizim();
                dataGridViewFurnizimeList.DataSource = fData;
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            this.Clear();
        }


        private void buttonPrintoFurnizim_Click(object sender, EventArgs e)
        {
            ((Form)printPreviewDialogFurnizimi).WindowState = FormWindowState.Maximized;
            if (printPreviewDialogFurnizimi.ShowDialog() == DialogResult.OK)
            {
                printDocumentFurnizim.Print();
            }
        }

        private void printDocumentFurnizim_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.DrawString("Fature Furnizimi", new Font("Times New Roman", 20, FontStyle.Bold), Brushes.Black, new PointF(300, 50));
            e.Graphics.DrawString("Furnizimi: ", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(200, 100));
            e.Graphics.DrawString(textBoxId.Text, new Font("Times New Roman", 14, FontStyle.Underline), Brushes.Black, new PointF(400, 100));

            e.Graphics.DrawString("Numer Fature: ", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(200, 150));
            e.Graphics.DrawString(comboBoxFurnizimi.Text, new Font("Times New Roman", 14, FontStyle.Underline), Brushes.Black, new PointF(400, 150));

            e.Graphics.DrawString("Data: ", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(200, 200));
            e.Graphics.DrawString(Convert.ToString(furnizimi.kokeFurnizimi.date), new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new PointF(400, 200));

            e.Graphics.DrawString("Artikulli: ", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(200, 250));
            e.Graphics.DrawString(comboBoxArtikulli.Text, new Font("Times New Roman", 14, FontStyle.Underline), Brushes.Black, new PointF(400, 250));

            e.Graphics.DrawString("Sasia: ", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(200, 300));
            e.Graphics.DrawString(textBoxSasi.Text, new Font("Times New Roman", 14, FontStyle.Underline), Brushes.Black, new PointF(400, 300));

            e.Graphics.DrawString("Cmimi: ", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(200, 350));
            e.Graphics.DrawString(textBoxCmimi.Text, new Font("Times New Roman", 14, FontStyle.Underline), Brushes.Black, new PointF(400, 350));
       
            e.Graphics.DrawString("Totali: ", new Font("Times New Roman", 20, FontStyle.Bold), Brushes.Black, new PointF(200, 400));
            e.Graphics.DrawString((Convert.ToInt32(textBoxSasi.Text)* Convert.ToInt32(textBoxCmimi.Text)).ToString(), new Font("Times New Roman", 20, FontStyle.Regular), Brushes.Black, new PointF(400, 400));

        }
    }
}
