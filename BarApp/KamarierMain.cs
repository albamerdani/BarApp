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
    public partial class KamarierMain : Form
    {
        public KamarierMain()
        {
            InitializeComponent();
        }

        private void tavolinatEMiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //KamarierTavolineView kamarierTavolineView = new KamarierTavolineView();
            //kamarierTavolineView.MdiParent = this;
            //kamarierTavolineView.StartPosition = FormStartPosition.CenterScreen;
            //kamarierTavolineView.Show();
        }

        private void faturatEMiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //KamarierFatureView kamarierFatureView = new KamarierFatureView();
            //kamarierFatureView.MdiParent = this;
            //kamarierFatureView.StartPosition = FormStartPosition.CenterScreen;
            //kamarierFatureView.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            this.Close();
            f.Show();
        }

        private void KamarierMain_Load(object sender, EventArgs e)
        {

        }
    }
}
