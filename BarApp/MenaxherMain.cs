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
    public partial class MenaxherMain : Form
    {
        public MenaxherMain()
        {
            InitializeComponent();
        }

        private void MenaxherMain_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kategoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artikullToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tavolinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.furnizimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.furnitoretEMiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturatEFurnizimeveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kamarieretEMiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriToolStripMenuItem,
            this.artikullToolStripMenuItem,
            this.tavolinaToolStripMenuItem,
            this.furnitoretEMiToolStripMenuItem,
            this.furnizimeToolStripMenuItem,
            this.faturatEFurnizimeveToolStripMenuItem,
            this.kamarieretEMiToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(816, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kategoriToolStripMenuItem
            // 
            this.kategoriToolStripMenuItem.Name = "kategoriToolStripMenuItem";
            this.kategoriToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.kategoriToolStripMenuItem.Text = "Kategori";
            // 
            // artikullToolStripMenuItem
            // 
            this.artikullToolStripMenuItem.Name = "artikullToolStripMenuItem";
            this.artikullToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.artikullToolStripMenuItem.Text = "Artikull";
            // 
            // tavolinaToolStripMenuItem
            // 
            this.tavolinaToolStripMenuItem.Name = "tavolinaToolStripMenuItem";
            this.tavolinaToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.tavolinaToolStripMenuItem.Text = "Tavolina";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 498);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(816, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // furnizimeToolStripMenuItem
            // 
            this.furnizimeToolStripMenuItem.Name = "furnizimeToolStripMenuItem";
            this.furnizimeToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.furnizimeToolStripMenuItem.Text = "Furnizime";
            // 
            // furnitoretEMiToolStripMenuItem
            // 
            this.furnitoretEMiToolStripMenuItem.Name = "furnitoretEMiToolStripMenuItem";
            this.furnitoretEMiToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.furnitoretEMiToolStripMenuItem.Text = "Furnitoret e Mi";
            // 
            // faturatEFurnizimeveToolStripMenuItem
            // 
            this.faturatEFurnizimeveToolStripMenuItem.Name = "faturatEFurnizimeveToolStripMenuItem";
            this.faturatEFurnizimeveToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.faturatEFurnizimeveToolStripMenuItem.Text = "Faturat e Furnizimeve";
            // 
            // kamarieretEMiToolStripMenuItem
            // 
            this.kamarieretEMiToolStripMenuItem.Name = "kamarieretEMiToolStripMenuItem";
            this.kamarieretEMiToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.kamarieretEMiToolStripMenuItem.Text = "Kamarieret e mi";
            // 
            // Menaxher
            // 
            this.ClientSize = new System.Drawing.Size(816, 520);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menaxher";
            this.Text = "Menaxher";
            this.Load += new System.EventHandler(this.MenaxherMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void kategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shtoKategori newKategori = new shtoKategori();
            newKategori.MdiParent = this;
            newKategori.Show();
        }

        private void artikullToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shtoArtikull newArtikull = new shtoArtikull();
            newArtikull.MdiParent = this;
            newArtikull.Show();
        }

        private void tavolinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shtoTavoline newTavoline = new shtoTavoline();
            newTavoline.MdiParent = this;
            newTavoline.Show();
        }

        private void furnizimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shtoFurnizime newFurnizime = new shtoFurnizime();
            newFurnizime.MdiParent = this;
            newFurnizime.Show();
        }

        private void furnitoretEMiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FurnitorView furnitorView = new FurnitorView();
            furnitorView.MdiParent = this;
            furnitorView.StartPosition = FormStartPosition.CenterScreen;
            furnitorView.Show();
        }

        private void faturatEFurnizimeveToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // FatureFurnizimView fatureFurnizimView = new FatureFurnizimView();
           // fatureFurnizimView.MdiParent = this;
           // fatureFurnizimView.StartPosition = FormStartPosition.CenterScreen;
            //fatureFurnizimView.Show();
        }

        private void kamarieretEMiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KamarierView kamarierView = new KamarierView();
            kamarierView.MdiParent = this;
            kamarierView.StartPosition = FormStartPosition.CenterScreen;
            kamarierView.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            this.Close();
            f.Show();
        }

    }
}
