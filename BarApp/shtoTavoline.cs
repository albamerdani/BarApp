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
    public partial class shtoTavoline : Form
    {
        Helper h = new Helper();
        Tavolina t = new Tavolina();

        public shtoTavoline()
        {
            InitializeComponent();
        }

        private void shtoTavoline_Load(object sender, EventArgs e)
        {
            //kamarieret e regjistruar
            string getKamarierQuery = "SELECT [Id],([Emer] + ' ' + [Mbiemer]) AS EmerMbiemerKamarieri FROM[dbo].[perdorues]";
            h.fillComboBox1(comboBoxKamarier, getKamarierQuery, "EmerMbiemerKamarieri", "Id");

            shtoBtn.Enabled = true;
            buttonNdrysho.Enabled = false;
            clearBtn.Enabled = false;

        }


        private void shtoBtn_Click(object sender, EventArgs e)
        {

    
            t.kamarier.id = Convert.ToInt32(comboBoxKamarier.SelectedValue.ToString());
            if (active.Checked)
            {
                t.status = 1;
            }
            else if (nonActive.Checked)
            {
                t.status = 0;
            }
            //t.status = comboBoxStatusVizite.Text;

            bool success = t.shtoTavoline(t);
            if (success)
            {
                MessageBox.Show("Shtimi i tavolines se re u krye me sukses!");
                this.Clear();
                DataTable tData = t.SelectTavolina();
                dataGridViewTavolinaList.DataSource = tData;
            }
            else
            {
                MessageBox.Show("Shtimi i tavolines se re deshtoi!");
            }


        }

        public void Clear()
        {
            shtoBtn.Enabled = true;
            buttonNdrysho.Enabled = false;
            clearBtn.Enabled = false;
            string getKamarierQuery = "SELECT [Id],([Emer] + ' ' + [Mbiemer]) AS EmerMbiemerKamarieri FROM[dbo].[perdorues]";
            h.fillComboBox1(comboBoxKamarier, getKamarierQuery, "EmerMbiemerKamarieri", "Id");

            //textBoxID.Text = "";
            comboBoxKamarier.DataSource = null;
            comboBoxKamarier.Items.Clear();
            //comboBoxStatus.SelectedIndex = -1;
        }

        private void buttonNdrysho_Click(object sender, EventArgs e)
        {

            //t.id = Convert.ToInt32(textBoxId.Text);
            t.kamarier.id = Convert.ToInt32(comboBoxKamarier.SelectedValue.ToString());
            if (active.Checked)
            {
                t.status = 1;
            }
            else if (nonActive.Checked)
            {
                t.status = 0;
            }

            if (t.ndrysho(t))
            {
                MessageBox.Show("Te dhenat e tavolines u modifikuan me sukses!");
                this.Clear();
                DataTable tData = t.SelectTavolina();
               dataGridViewTavolinaList.DataSource = tData;
            }
            else
            {
                MessageBox.Show("Gabim! Te dhenat e tavolines nuk u modifikuan!");
            }
        }

        private void dataGridViewTavolinaList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            shtoBtn.Enabled = false;
            buttonNdrysho.Enabled = true;
            clearBtn.Enabled = true;
            int rowIndex = e.RowIndex;

            textBoxId.Text = dataGridViewTavolinaList.Rows[rowIndex].Cells[0].Value.ToString();
            comboBoxKamarier.Text = dataGridViewTavolinaList.Rows[rowIndex].Cells[1].Value.ToString();
            active.Text = dataGridViewTavolinaList.Rows[rowIndex].Cells[2].Value.ToString();
            //nonActive.Text = dataGridViewKategoriList.Rows[rowIndex].Cells[6].Value.ToString();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            this.Clear();
        }
    }
}
