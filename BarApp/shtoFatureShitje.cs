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
    public partial class shtoFatureShitje : Form
    {
        Helper h = new Helper();
        FatureShitje fsh = new FatureShitje();

        public shtoFatureShitje()
        {
            InitializeComponent();
        }

        private void shtoFatureShitje_Load(object sender, EventArgs e)
        {
            //load artikujt ekzistues
            dataGridViewFaturaList.DataSource = fsh.SelectFatureShitje();

            string getArtikullQuery = "SELECT[Id],([Artikulli] FROM[dbo].[artikull] WHERE [Status] = 1";
            h.fillComboBox1(comboBoxArtikulli, getArtikullQuery, "Artikulli", "Id");

            string getKokeFatureQuery = "SELECT [Id], [Nr_fature] FROM[dbo].[koke_fature]";
            h.fillComboBox1(comboBoxFatura, getKokeFatureQuery, "Nr_fature", "Id");

            shtoBtn.Enabled = true;
            buttonNdrysho.Enabled = false;
            buttonFshi.Enabled = false;
            buttonPrintoFurnizim.Enabled = false;
            clearBtn.Enabled = false;
        }


        private void shtoBtn_Click(object sender, EventArgs e)
        {
            fsh.a.id = (int)comboBoxArtikulli.SelectedValue;
            fsh.sasiaShitjes = Convert.ToInt32(textBoxSasi.Text);
            //fsh.cmimiShitjes = Convert.ToInt32(textBoxCmimi.Text);
            fsh.kokeFature.id = (int)comboBoxFatura.SelectedValue;


            bool success = fsh.shtoFature(fsh);
            if (success)
            {
                MessageBox.Show("Shtimi i fatures se re u krye me sukses!");
                this.Clear();
                DataTable fData = fsh.SelectFatureShitje();
                dataGridViewFaturaList.DataSource = fData;
            }
            else
            {
                MessageBox.Show("Shtimi i fatures se re deshtoi!");
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

            string getKokeFatureQuery = "SELECT [Id], [Nr_fature] FROM[dbo].[koke_fature]";
            h.fillComboBox1(comboBoxFatura, getKokeFatureQuery, "Nr_fature", "Id");

            textBoxId.Text = "";
        }


        private void buttonNdrysho_Click(object sender, EventArgs e)
        {
            fsh.a.id = (int)comboBoxArtikulli.SelectedValue;
            fsh.sasiaShitjes = Convert.ToInt32(textBoxSasi.Text);
            fsh.kokeFature.id = (int)comboBoxFatura.SelectedValue;

            if (fsh.ndryshoFature(fsh))
            {
                MessageBox.Show("Te dhenat e fatures u modifikuan me sukses!");
                this.Clear();
                DataTable viziteData = fsh.SelectFatureShitje();
                dataGridViewFaturaList.DataSource = viziteData;
            }
            else
            {
                MessageBox.Show("Gabim! Te dhenat e fatures nuk u modifikuan!");
            }
        }

        private void buttonFshi_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(textBoxId.Text, out id);
            fsh.id = id;
            if (fsh.fshiFature(fsh))
            {
                MessageBox.Show("Te dhenat e fatures u fshine me sukses");
                this.Clear();
                DataTable viziteData = fsh.SelectFatureShitje();
                dataGridViewFaturaList.DataSource = viziteData;
            }
            else
            {
                MessageBox.Show("Gabim! Te dhenat e fatures nuk u fshine!");
            }
        }

        private void dataGridViewFaturaList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            shtoBtn.Enabled = false;
            buttonNdrysho.Enabled = true;
            buttonFshi.Enabled = true;
            buttonPrintoFurnizim.Enabled = true;
            clearBtn.Enabled = true;
            int rowIndex = e.RowIndex;

            textBoxId.Text = dataGridViewFaturaList.Rows[rowIndex].Cells[0].Value.ToString();
            comboBoxArtikulli.Text = dataGridViewFaturaList.Rows[rowIndex].Cells[1].Value.ToString();
            textBoxSasi.Text = dataGridViewFaturaList.Rows[rowIndex].Cells[2].Value.ToString();
            textBoxCmimi.Text = dataGridViewFaturaList.Rows[rowIndex].Cells[3].Value.ToString();
            comboBoxFatura.Text = dataGridViewFaturaList.Rows[rowIndex].Cells[4].Value.ToString();
        }


        private void textBoxKerko_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxKerko.Text;
            dataGridViewFaturaList.DataSource = fsh.KerkoFature(keyword);
            if (keyword == "")
            {
                DataTable fData = fsh.SelectFatureShitje();
                dataGridViewFaturaList.DataSource = fData;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void buttonPrintoFature_Click(object sender, EventArgs e)
        {
            ((Form)printPreviewDialogFature).WindowState = FormWindowState.Maximized;
            if (printPreviewDialogFature.ShowDialog() == DialogResult.OK)
            {
                printDocumentFature.Print();
            }
        }

        private void printDocumentFature_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.DrawString("Fature Shitje", new Font("Times New Roman", 20, FontStyle.Bold), Brushes.Black, new PointF(200, 50));
            e.Graphics.DrawString("Fatura: ", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(200, 100));
            e.Graphics.DrawString(textBoxId.Text, new Font("Times New Roman", 14, FontStyle.Underline), Brushes.Black, new PointF(400, 100));

            e.Graphics.DrawString("Numer Fature: ", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(200, 150));
            e.Graphics.DrawString(comboBoxFatura.Text, new Font("Times New Roman", 14, FontStyle.Underline), Brushes.Black, new PointF(400, 150));

            e.Graphics.DrawString("Data: ", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(200, 200));
            e.Graphics.DrawString(Convert.ToString(fsh.kokeFature.data), new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new PointF(400, 200));

            e.Graphics.DrawString("Artikulli: ", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(200, 250));
            e.Graphics.DrawString(comboBoxArtikulli.Text, new Font("Times New Roman", 14, FontStyle.Underline), Brushes.Black, new PointF(400, 250));

            e.Graphics.DrawString("Sasia: ", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(200, 300));
            e.Graphics.DrawString(textBoxSasi.Text, new Font("Times New Roman", 14, FontStyle.Underline), Brushes.Black, new PointF(400, 300));

            e.Graphics.DrawString("Cmimi: ", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(200, 350));
            e.Graphics.DrawString(textBoxCmimi.Text, new Font("Times New Roman", 14, FontStyle.Underline), Brushes.Black, new PointF(400, 350));

            e.Graphics.DrawString("Totali: ", new Font("Times New Roman", 20, FontStyle.Bold), Brushes.Black, new PointF(200, 400));
            e.Graphics.DrawString((Convert.ToInt32(textBoxSasi.Text) * Convert.ToInt32(textBoxCmimi.Text)).ToString(), new Font("Times New Roman", 20, FontStyle.Regular), Brushes.Black, new PointF(200, 400));

        }
    }
}
