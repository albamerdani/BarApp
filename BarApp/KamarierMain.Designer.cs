namespace BarApp
{
    partial class KamarierMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tavolinatEMiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturatEMiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tavolinatEMiaToolStripMenuItem,
            this.faturatEMiaToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tavolinatEMiaToolStripMenuItem
            // 
            this.tavolinatEMiaToolStripMenuItem.Name = "tavolinatEMiaToolStripMenuItem";
            this.tavolinatEMiaToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.tavolinatEMiaToolStripMenuItem.Text = "Tavolinat e Mia";
            // 
            // faturatEMiaToolStripMenuItem
            // 
            this.faturatEMiaToolStripMenuItem.Name = "faturatEMiaToolStripMenuItem";
            this.faturatEMiaToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.faturatEMiaToolStripMenuItem.Text = "Faturat e mia";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // Kamarier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Kamarier";
            this.Text = "Kamarier";
            this.Load += new System.EventHandler(this.KamarierMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tavolinatEMiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturatEMiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}