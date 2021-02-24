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
    public partial class shtoKokeFature : Form
    {
        KokeFature kf = new KokeFature();
        Helper h = new Helper();
        
        public shtoKokeFature()
        {
            InitializeComponent();
        }

        private void shtoKokeFature_Load(object sender, EventArgs e)
        {
            //load vizitat ekzistuese
            dataGridViewKokeFatureList.DataSource = kf.SelectKokeFature();
            kf.kamarier.id = kf.kamarier.getIdPerdoruesByUsername(Login.uname);

            //tavolinat e regjistruar
            string getTavolinaQuery = "SELECT [Id] FROM[dbo].[tavolina] WHERE Id_kamarier = '" + kf.kamarier.id +"' AND Status = 1";
            h.fillComboBox1(comboBoxTavolina, getTavolinaQuery, "Id", "Id");

            shtoBtn.Enabled = true;
            buttonNdrysho.Enabled = false;
            clearBtn.Enabled = false;

        }


        private void shtoBtn_Click(object sender, EventArgs e)
        {

            kf.t.id = (int)comboBoxTavolina.SelectedValue;
            kf.data = dateTimePickerData.Value;
            kf.nrFature = textBoxNrFature.Text;
            if (active.Checked)
            {
                kf.status = 1;
            }
            else if (nonActive.Checked)
            {
                kf.status = 0;
            }

            if (comboBoxStatus.SelectedValue.ToString().Equals("Aktiv") )
            {
                kf.status = 1;
            }
            else
            {
                kf.status = 0;
            }

            bool success = kf.shtoKokeFature(kf);
            if (success)
            {
                MessageBox.Show("Shtimi i kokes se fatures u krye me sukses!");
                this.Clear();
                DataTable kfData = kf.SelectKokeFature();
                dataGridViewKokeFatureList.DataSource = kfData;
            }
            else
            {
                MessageBox.Show("Shtimi i  kokes se fatures deshtoi!");
            }


        }

        public void Clear()
        {
            shtoBtn.Enabled = true;
            buttonNdrysho.Enabled = false;
            clearBtn.Enabled = false;

            //tavolinat e kamarierit te loguar
            string getTavolinaQuery = "SELECT [Id] FROM[dbo].[tavolina] WHERE Id_kamarier = '" + kf.kamarier.id + "' AND Status = 1";
            h.fillComboBox1(comboBoxTavolina, getTavolinaQuery, "Id", "Id");

            textBoxId.Text = "";
            textBoxNrFature.Text = "";
            dateTimePickerData.Value = DateTime.Now;

        }



        private void buttonNdrysho_Click(object sender, EventArgs e)
        {
            kf.id = Convert.ToInt32(textBoxId.Text);
            kf.t.id = (int)comboBoxTavolina.SelectedValue;
            kf.data = dateTimePickerData.Value;
            kf.nrFature = textBoxNrFature.Text;
            if (active.Checked)
            {
                kf.status = 1;
            }
            else if (nonActive.Checked)
            {
                kf.status = 0;
            }

            if (comboBoxStatus.SelectedValue.ToString().Equals("Aktiv"))
            {
                kf.status = 1;
            }
            else
            {
                kf.status = 0;
            }

            if (kf.ndryshoKokeFature(kf))
            {
                MessageBox.Show("Te dhenat e kokes se fatures u modifikuan me sukses!");
                this.Clear();
                DataTable kfData = kf.SelectKokeFature();
                dataGridViewKokeFatureList.DataSource = kfData;
            }
            else
            {
                MessageBox.Show("Gabim! Te dhenat e kokes se fatures nuk u modifikuan!");
            }
        }

        private void dataGridViewKokeFatureList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            shtoBtn.Enabled = false;
            buttonNdrysho.Enabled = true;
            clearBtn.Enabled = true;
            int rowIndex = e.RowIndex;

            textBoxId.Text = dataGridViewKokeFatureList.Rows[rowIndex].Cells[0].Value.ToString();
            comboBoxTavolina.Text = dataGridViewKokeFatureList.Rows[rowIndex].Cells[1].Value.ToString();
            dateTimePickerData.Value = Convert.ToDateTime(dataGridViewKokeFatureList.Rows[rowIndex].Cells[2].Value.ToString());
            active.Text = dataGridViewKokeFatureList.Rows[rowIndex].Cells[3].Value.ToString();
            if (dataGridViewKokeFatureList.Rows[rowIndex].Cells[3].Value.ToString().Equals("1")) {
                comboBoxStatus.Text = "Aktiv";
            }
            else
            {
                comboBoxStatus.Text = "Jo Aktiv";
            }
            textBoxNrFature.Text = dataGridViewKokeFatureList.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void textBoxKerko_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxKerko.Text;
            dataGridViewKokeFatureList.DataSource = kf.KerkoKokeFature(keyword);
            if (keyword == "")
            {
                DataTable viziteData = kf.SelectKokeFature();
                dataGridViewKokeFatureList.DataSource = viziteData;
            }
        }
    }
}
