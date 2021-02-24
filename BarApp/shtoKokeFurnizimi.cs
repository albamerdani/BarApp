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
    public partial class shtoKokeFurnizimi : Form
    {
        Helper h = new Helper();
        KokeFurnizimi kf = new KokeFurnizimi();
       
        public shtoKokeFurnizimi()
        {
            InitializeComponent();
            dateTimePickerData.CustomFormat = "dd-mm-yyyy ";
        }

        private void shtoKokeFurnizimi_Load(object sender, EventArgs e)
        {
            //load vizitat ekzistuese
            dataGridViewKokeFurnizimiList.DataSource = kf.SelectKokeFurnizimi();
            
            //furnitoret e regjistruar
            string getFurnitorQuery = "SELECT [Id],[Emer] FROM[dbo].[Furnitori]";
            h.fillComboBox1(comboBoxFurnitori, getFurnitorQuery, "Emer", "Id");
            
            shtoBtn.Enabled = true;
            buttonNdrysho.Enabled = false;
            clearBtn.Enabled = false;

        }


        private void shtoBtn_Click(object sender, EventArgs e)
        {

            kf.f.id = (int)comboBoxFurnitori.SelectedValue; 
            kf.date = dateTimePickerData.Value;
            kf.nr_fature = textBoxNrFature.Text;
           
            bool success = kf.shtoKokeFurnizimi(kf);
            if (success)
            {
                MessageBox.Show("Shtimi i kokes se furnizimit u krye me sukses!");
                this.Clear();
                DataTable kfData = kf.SelectKokeFurnizimi();
                dataGridViewKokeFurnizimiList.DataSource = kfData;
            }
            else
            {
                MessageBox.Show("Shtimi i  kokes se furnizimit deshtoi!");
            }


        }

        public void Clear()
        {
            shtoBtn.Enabled = true;
            buttonNdrysho.Enabled = false;
            clearBtn.Enabled = false;
            //furnitoret e regjistruar
            string getFurnitorQuery = "SELECT [Id],[Emer] FROM[dbo].[Furnitori]";
            h.fillComboBox1(comboBoxFurnitori, getFurnitorQuery, "Emer", "Id");

            textBoxId.Text = "";
            textBoxNrFature.Text = "";
            dateTimePickerData.Value = DateTime.Now;

        }



        private void buttonNdrysho_Click(object sender, EventArgs e)
        {
            kf.id = Convert.ToInt32(textBoxId.Text);
            kf.f.id = (int)comboBoxFurnitori.SelectedValue;
            kf.date = dateTimePickerData.Value;
            kf.nr_fature = textBoxNrFature.Text;

            if (kf.ndryshoKokeFurnizimi(kf))
            {
                MessageBox.Show("Te dhenat e kokes se furnizimit u modifikuan me sukses!");
                this.Clear();
                DataTable kfData = kf.SelectKokeFurnizimi();
                dataGridViewKokeFurnizimiList.DataSource = kfData;
            }
            else
            {
                MessageBox.Show("Gabim! Te dhenat e kokes se furnizimit nuk u modifikuan!");
            }
        }

        private void dataGridViewKokeFurnizimiList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            shtoBtn.Enabled = false;
            buttonNdrysho.Enabled = true;
            clearBtn.Enabled = true;
            int rowIndex = e.RowIndex;

            textBoxId.Text = dataGridViewKokeFurnizimiList.Rows[rowIndex].Cells[0].Value.ToString();
            comboBoxFurnitori.Text = dataGridViewKokeFurnizimiList.Rows[rowIndex].Cells[1].Value.ToString();
            dateTimePickerData.Value = Convert.ToDateTime(dataGridViewKokeFurnizimiList.Rows[rowIndex].Cells[2].Value.ToString());
            textBoxNrFature.Text = dataGridViewKokeFurnizimiList.Rows[rowIndex].Cells[3].Value.ToString();

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void textBoxKerko_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxKerko.Text;
            dataGridViewKokeFurnizimiList.DataSource = kf.KerkoKokeFurnizimi(keyword);
            if (keyword == "")
            {
                DataTable viziteData = kf.SelectKokeFurnizimi();
                dataGridViewKokeFurnizimiList.DataSource = viziteData;
            }
        }

    }
}
