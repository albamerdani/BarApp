namespace BarApp
{
    partial class shtoKategori
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
            this.nonActive = new System.Windows.Forms.CheckBox();
            this.active = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.shtoBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.emertimTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxKategoriteEkzistuese = new System.Windows.Forms.GroupBox();
            this.textBoxKerko = new System.Windows.Forms.TextBox();
            this.labelKerkoSipasID = new System.Windows.Forms.Label();
            this.dataGridViewKategoriList = new System.Windows.Forms.DataGridView();
            this.buttonNdrysho = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.groupBoxKategoriteEkzistuese.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategoriList)).BeginInit();
            this.SuspendLayout();
            // 
            // nonActive
            // 
            this.nonActive.AutoSize = true;
            this.nonActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nonActive.Location = new System.Drawing.Point(249, 153);
            this.nonActive.Margin = new System.Windows.Forms.Padding(4);
            this.nonActive.Name = "nonActive";
            this.nonActive.Size = new System.Drawing.Size(101, 29);
            this.nonActive.TabIndex = 38;
            this.nonActive.Text = "Jo aktiv";
            this.nonActive.UseVisualStyleBackColor = true;
            // 
            // active
            // 
            this.active.AutoSize = true;
            this.active.Checked = true;
            this.active.CheckState = System.Windows.Forms.CheckState.Checked;
            this.active.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.active.Location = new System.Drawing.Point(140, 153);
            this.active.Margin = new System.Windows.Forms.Padding(4);
            this.active.Name = "active";
            this.active.Size = new System.Drawing.Size(77, 29);
            this.active.TabIndex = 37;
            this.active.Text = "Aktiv";
            this.active.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(11, 153);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 34);
            this.label10.TabIndex = 36;
            this.label10.Text = "Status";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // shtoBtn
            // 
            this.shtoBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.shtoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.shtoBtn.Location = new System.Drawing.Point(211, 230);
            this.shtoBtn.Margin = new System.Windows.Forms.Padding(4);
            this.shtoBtn.Name = "shtoBtn";
            this.shtoBtn.Size = new System.Drawing.Size(134, 58);
            this.shtoBtn.TabIndex = 35;
            this.shtoBtn.Text = "Shto";
            this.shtoBtn.UseVisualStyleBackColor = false;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Orange;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.clearBtn.Location = new System.Drawing.Point(119, 334);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(134, 58);
            this.clearBtn.TabIndex = 34;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            // 
            // emertimTxtBox
            // 
            this.emertimTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.emertimTxtBox.Location = new System.Drawing.Point(140, 91);
            this.emertimTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.emertimTxtBox.Name = "emertimTxtBox";
            this.emertimTxtBox.Size = new System.Drawing.Size(210, 30);
            this.emertimTxtBox.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(11, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 34);
            this.label1.TabIndex = 28;
            this.label1.Text = "Emertim";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxKategoriteEkzistuese
            // 
            this.groupBoxKategoriteEkzistuese.Controls.Add(this.textBoxKerko);
            this.groupBoxKategoriteEkzistuese.Controls.Add(this.labelKerkoSipasID);
            this.groupBoxKategoriteEkzistuese.Controls.Add(this.dataGridViewKategoriList);
            this.groupBoxKategoriteEkzistuese.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxKategoriteEkzistuese.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBoxKategoriteEkzistuese.Location = new System.Drawing.Point(368, 14);
            this.groupBoxKategoriteEkzistuese.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxKategoriteEkzistuese.Name = "groupBoxKategoriteEkzistuese";
            this.groupBoxKategoriteEkzistuese.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxKategoriteEkzistuese.Size = new System.Drawing.Size(735, 426);
            this.groupBoxKategoriteEkzistuese.TabIndex = 39;
            this.groupBoxKategoriteEkzistuese.TabStop = false;
            this.groupBoxKategoriteEkzistuese.Text = "Kategori ekzistuese";
            // 
            // textBoxKerko
            // 
            this.textBoxKerko.Location = new System.Drawing.Point(99, 46);
            this.textBoxKerko.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxKerko.Name = "textBoxKerko";
            this.textBoxKerko.Size = new System.Drawing.Size(277, 30);
            this.textBoxKerko.TabIndex = 30;
            // 
            // labelKerkoSipasID
            // 
            this.labelKerkoSipasID.AutoSize = true;
            this.labelKerkoSipasID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelKerkoSipasID.Location = new System.Drawing.Point(8, 46);
            this.labelKerkoSipasID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKerkoSipasID.Name = "labelKerkoSipasID";
            this.labelKerkoSipasID.Size = new System.Drawing.Size(70, 25);
            this.labelKerkoSipasID.TabIndex = 29;
            this.labelKerkoSipasID.Text = "Kerko:";
            // 
            // dataGridViewKategoriList
            // 
            this.dataGridViewKategoriList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKategoriList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKategoriList.Location = new System.Drawing.Point(13, 99);
            this.dataGridViewKategoriList.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewKategoriList.Name = "dataGridViewKategoriList";
            this.dataGridViewKategoriList.Size = new System.Drawing.Size(714, 319);
            this.dataGridViewKategoriList.TabIndex = 0;
            // 
            // buttonNdrysho
            // 
            this.buttonNdrysho.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonNdrysho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonNdrysho.Location = new System.Drawing.Point(16, 230);
            this.buttonNdrysho.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNdrysho.Name = "buttonNdrysho";
            this.buttonNdrysho.Size = new System.Drawing.Size(134, 58);
            this.buttonNdrysho.TabIndex = 40;
            this.buttonNdrysho.Text = "Ndrysho";
            this.buttonNdrysho.UseVisualStyleBackColor = false;
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxId.Location = new System.Drawing.Point(142, 30);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(210, 30);
            this.textBoxId.TabIndex = 42;
            // 
            // labelID
            // 
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelID.Location = new System.Drawing.Point(13, 28);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(106, 34);
            this.labelID.TabIndex = 41;
            this.labelID.Text = "Id";
            this.labelID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // shtoKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 453);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.buttonNdrysho);
            this.Controls.Add(this.groupBoxKategoriteEkzistuese);
            this.Controls.Add(this.nonActive);
            this.Controls.Add(this.active);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.shtoBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.emertimTxtBox);
            this.Controls.Add(this.label1);
            this.Name = "shtoKategori";
            this.Text = "Kategori";
            this.Load += new System.EventHandler(this.shtoKategori_Load);
            this.groupBoxKategoriteEkzistuese.ResumeLayout(false);
            this.groupBoxKategoriteEkzistuese.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategoriList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox nonActive;
        private System.Windows.Forms.CheckBox active;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button shtoBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.TextBox emertimTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxKategoriteEkzistuese;
        private System.Windows.Forms.TextBox textBoxKerko;
        private System.Windows.Forms.Label labelKerkoSipasID;
        private System.Windows.Forms.DataGridView dataGridViewKategoriList;
        private System.Windows.Forms.Button buttonNdrysho;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelID;
    }
}