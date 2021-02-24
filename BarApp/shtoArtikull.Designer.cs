namespace BarApp
{
    partial class shtoArtikull
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(shtoArtikull));
            this.printPreviewDialogFature = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocumentFature = new System.Drawing.Printing.PrintDocument();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonShtoArtikull = new System.Windows.Forms.Button();
            this.buttonNdryshoArtikull = new System.Windows.Forms.Button();
            this.textBoxKerko = new System.Windows.Forms.TextBox();
            this.labelKerkoSipasID = new System.Windows.Forms.Label();
            this.dataGridViewArtikullList = new System.Windows.Forms.DataGridView();
            this.groupBoxArtikujtEkzistues = new System.Windows.Forms.GroupBox();
            this.groupBoxTedhenatEArtikullit = new System.Windows.Forms.GroupBox();
            this.nonActive = new System.Windows.Forms.CheckBox();
            this.active = new System.Windows.Forms.CheckBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxCmimi = new System.Windows.Forms.TextBox();
            this.labelCmimi = new System.Windows.Forms.Label();
            this.textBoxSasia = new System.Windows.Forms.TextBox();
            this.labelSasia = new System.Windows.Forms.Label();
            this.textBoxArtikulli = new System.Windows.Forms.TextBox();
            this.labelArtikulli = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.comboBoxKategori = new System.Windows.Forms.ComboBox();
            this.comboBoxNjesia = new System.Windows.Forms.ComboBox();
            this.labelNjesia = new System.Windows.Forms.Label();
            this.labelKategoria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtikullList)).BeginInit();
            this.groupBoxArtikujtEkzistues.SuspendLayout();
            this.groupBoxTedhenatEArtikullit.SuspendLayout();
            this.SuspendLayout();
            // 
            // printPreviewDialogFature
            // 
            this.printPreviewDialogFature.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogFature.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogFature.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogFature.Document = this.printDocumentFature;
            this.printPreviewDialogFature.Enabled = true;
            this.printPreviewDialogFature.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogFature.Icon")));
            this.printPreviewDialogFature.Name = "printPreviewDialogFature";
            this.printPreviewDialogFature.Visible = false;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Orange;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(445, 527);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(184, 55);
            this.buttonClear.TabIndex = 21;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            // 
            // buttonShtoArtikull
            // 
            this.buttonShtoArtikull.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonShtoArtikull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShtoArtikull.ForeColor = System.Drawing.Color.White;
            this.buttonShtoArtikull.Location = new System.Drawing.Point(13, 527);
            this.buttonShtoArtikull.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShtoArtikull.Name = "buttonShtoArtikull";
            this.buttonShtoArtikull.Size = new System.Drawing.Size(203, 55);
            this.buttonShtoArtikull.TabIndex = 16;
            this.buttonShtoArtikull.Text = "Shto Artikull";
            this.buttonShtoArtikull.UseVisualStyleBackColor = false;
            // 
            // buttonNdryshoArtikull
            // 
            this.buttonNdryshoArtikull.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonNdryshoArtikull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNdryshoArtikull.ForeColor = System.Drawing.Color.White;
            this.buttonNdryshoArtikull.Location = new System.Drawing.Point(240, 527);
            this.buttonNdryshoArtikull.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNdryshoArtikull.Name = "buttonNdryshoArtikull";
            this.buttonNdryshoArtikull.Size = new System.Drawing.Size(187, 55);
            this.buttonNdryshoArtikull.TabIndex = 17;
            this.buttonNdryshoArtikull.Text = "Ndrysho Artikull";
            this.buttonNdryshoArtikull.UseVisualStyleBackColor = false;
            // 
            // textBoxKerko
            // 
            this.textBoxKerko.Location = new System.Drawing.Point(101, 59);
            this.textBoxKerko.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxKerko.Name = "textBoxKerko";
            this.textBoxKerko.Size = new System.Drawing.Size(277, 30);
            this.textBoxKerko.TabIndex = 30;
            // 
            // labelKerkoSipasID
            // 
            this.labelKerkoSipasID.AutoSize = true;
            this.labelKerkoSipasID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelKerkoSipasID.Location = new System.Drawing.Point(8, 67);
            this.labelKerkoSipasID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKerkoSipasID.Name = "labelKerkoSipasID";
            this.labelKerkoSipasID.Size = new System.Drawing.Size(70, 25);
            this.labelKerkoSipasID.TabIndex = 29;
            this.labelKerkoSipasID.Text = "Kerko:";
            // 
            // dataGridViewArtikullList
            // 
            this.dataGridViewArtikullList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewArtikullList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArtikullList.Location = new System.Drawing.Point(13, 107);
            this.dataGridViewArtikullList.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewArtikullList.Name = "dataGridViewArtikullList";
            this.dataGridViewArtikullList.Size = new System.Drawing.Size(859, 387);
            this.dataGridViewArtikullList.TabIndex = 0;
            // 
            // groupBoxArtikujtEkzistues
            // 
            this.groupBoxArtikujtEkzistues.Controls.Add(this.textBoxKerko);
            this.groupBoxArtikujtEkzistues.Controls.Add(this.labelKerkoSipasID);
            this.groupBoxArtikujtEkzistues.Controls.Add(this.dataGridViewArtikullList);
            this.groupBoxArtikujtEkzistues.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxArtikujtEkzistues.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBoxArtikujtEkzistues.Location = new System.Drawing.Point(454, 13);
            this.groupBoxArtikujtEkzistues.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxArtikujtEkzistues.Name = "groupBoxArtikujtEkzistues";
            this.groupBoxArtikujtEkzistues.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxArtikujtEkzistues.Size = new System.Drawing.Size(886, 506);
            this.groupBoxArtikujtEkzistues.TabIndex = 19;
            this.groupBoxArtikujtEkzistues.TabStop = false;
            this.groupBoxArtikujtEkzistues.Text = "Artikujt ekzistues";
            // 
            // groupBoxTedhenatEArtikullit
            // 
            this.groupBoxTedhenatEArtikullit.Controls.Add(this.nonActive);
            this.groupBoxTedhenatEArtikullit.Controls.Add(this.active);
            this.groupBoxTedhenatEArtikullit.Controls.Add(this.labelStatus);
            this.groupBoxTedhenatEArtikullit.Controls.Add(this.textBoxCmimi);
            this.groupBoxTedhenatEArtikullit.Controls.Add(this.labelCmimi);
            this.groupBoxTedhenatEArtikullit.Controls.Add(this.textBoxSasia);
            this.groupBoxTedhenatEArtikullit.Controls.Add(this.labelSasia);
            this.groupBoxTedhenatEArtikullit.Controls.Add(this.textBoxArtikulli);
            this.groupBoxTedhenatEArtikullit.Controls.Add(this.labelArtikulli);
            this.groupBoxTedhenatEArtikullit.Controls.Add(this.textBoxID);
            this.groupBoxTedhenatEArtikullit.Controls.Add(this.labelID);
            this.groupBoxTedhenatEArtikullit.Controls.Add(this.comboBoxKategori);
            this.groupBoxTedhenatEArtikullit.Controls.Add(this.comboBoxNjesia);
            this.groupBoxTedhenatEArtikullit.Controls.Add(this.labelNjesia);
            this.groupBoxTedhenatEArtikullit.Controls.Add(this.labelKategoria);
            this.groupBoxTedhenatEArtikullit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTedhenatEArtikullit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBoxTedhenatEArtikullit.Location = new System.Drawing.Point(5, 13);
            this.groupBoxTedhenatEArtikullit.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxTedhenatEArtikullit.Name = "groupBoxTedhenatEArtikullit";
            this.groupBoxTedhenatEArtikullit.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxTedhenatEArtikullit.Size = new System.Drawing.Size(441, 506);
            this.groupBoxTedhenatEArtikullit.TabIndex = 23;
            this.groupBoxTedhenatEArtikullit.TabStop = false;
            this.groupBoxTedhenatEArtikullit.Text = "Plotëso të dhënat e artikullit";
            // 
            // nonActive
            // 
            this.nonActive.AutoSize = true;
            this.nonActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nonActive.ForeColor = System.Drawing.SystemColors.InfoText;
            this.nonActive.Location = new System.Drawing.Point(321, 456);
            this.nonActive.Margin = new System.Windows.Forms.Padding(4);
            this.nonActive.Name = "nonActive";
            this.nonActive.Size = new System.Drawing.Size(101, 29);
            this.nonActive.TabIndex = 46;
            this.nonActive.Text = "Jo aktiv";
            this.nonActive.UseVisualStyleBackColor = true;
            // 
            // active
            // 
            this.active.AutoSize = true;
            this.active.Checked = true;
            this.active.CheckState = System.Windows.Forms.CheckState.Checked;
            this.active.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.active.ForeColor = System.Drawing.SystemColors.InfoText;
            this.active.Location = new System.Drawing.Point(212, 455);
            this.active.Margin = new System.Windows.Forms.Padding(4);
            this.active.Name = "active";
            this.active.Size = new System.Drawing.Size(77, 29);
            this.active.TabIndex = 45;
            this.active.Text = "Aktiv";
            this.active.UseVisualStyleBackColor = true;
            // 
            // labelStatus
            // 
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelStatus.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelStatus.Location = new System.Drawing.Point(12, 450);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(160, 34);
            this.labelStatus.TabIndex = 44;
            this.labelStatus.Text = "Status";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxCmimi
            // 
            this.textBoxCmimi.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBoxCmimi.Location = new System.Drawing.Point(155, 259);
            this.textBoxCmimi.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCmimi.Name = "textBoxCmimi";
            this.textBoxCmimi.ReadOnly = true;
            this.textBoxCmimi.Size = new System.Drawing.Size(277, 30);
            this.textBoxCmimi.TabIndex = 43;
            // 
            // labelCmimi
            // 
            this.labelCmimi.AutoSize = true;
            this.labelCmimi.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelCmimi.Location = new System.Drawing.Point(12, 259);
            this.labelCmimi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCmimi.Name = "labelCmimi";
            this.labelCmimi.Size = new System.Drawing.Size(122, 25);
            this.labelCmimi.TabIndex = 42;
            this.labelCmimi.Text = "Cmimi (leke)";
            // 
            // textBoxSasia
            // 
            this.textBoxSasia.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBoxSasia.Location = new System.Drawing.Point(156, 186);
            this.textBoxSasia.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSasia.Name = "textBoxSasia";
            this.textBoxSasia.ReadOnly = true;
            this.textBoxSasia.Size = new System.Drawing.Size(277, 30);
            this.textBoxSasia.TabIndex = 41;
            // 
            // labelSasia
            // 
            this.labelSasia.AutoSize = true;
            this.labelSasia.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelSasia.Location = new System.Drawing.Point(12, 189);
            this.labelSasia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSasia.Name = "labelSasia";
            this.labelSasia.Size = new System.Drawing.Size(62, 25);
            this.labelSasia.TabIndex = 40;
            this.labelSasia.Text = "Sasia";
            // 
            // textBoxArtikulli
            // 
            this.textBoxArtikulli.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBoxArtikulli.Location = new System.Drawing.Point(155, 116);
            this.textBoxArtikulli.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxArtikulli.Name = "textBoxArtikulli";
            this.textBoxArtikulli.ReadOnly = true;
            this.textBoxArtikulli.Size = new System.Drawing.Size(277, 30);
            this.textBoxArtikulli.TabIndex = 39;
            // 
            // labelArtikulli
            // 
            this.labelArtikulli.AutoSize = true;
            this.labelArtikulli.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelArtikulli.Location = new System.Drawing.Point(12, 119);
            this.labelArtikulli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelArtikulli.Name = "labelArtikulli";
            this.labelArtikulli.Size = new System.Drawing.Size(74, 25);
            this.labelArtikulli.TabIndex = 38;
            this.labelArtikulli.Text = "Artikulli";
            // 
            // textBoxID
            // 
            this.textBoxID.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBoxID.Location = new System.Drawing.Point(155, 44);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(277, 30);
            this.textBoxID.TabIndex = 37;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelID.Location = new System.Drawing.Point(12, 44);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(31, 25);
            this.labelID.TabIndex = 36;
            this.labelID.Text = "ID";
            // 
            // comboBoxKategori
            // 
            this.comboBoxKategori.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxKategori.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxKategori.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboBoxKategori.FormattingEnabled = true;
            this.comboBoxKategori.Items.AddRange(new object[] {
            "Femer",
            "Mashkull",
            "Tjeter"});
            this.comboBoxKategori.Location = new System.Drawing.Point(155, 397);
            this.comboBoxKategori.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxKategori.Name = "comboBoxKategori";
            this.comboBoxKategori.Size = new System.Drawing.Size(277, 33);
            this.comboBoxKategori.TabIndex = 33;
            // 
            // comboBoxNjesia
            // 
            this.comboBoxNjesia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxNjesia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxNjesia.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboBoxNjesia.FormattingEnabled = true;
            this.comboBoxNjesia.Location = new System.Drawing.Point(155, 324);
            this.comboBoxNjesia.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxNjesia.Name = "comboBoxNjesia";
            this.comboBoxNjesia.Size = new System.Drawing.Size(277, 33);
            this.comboBoxNjesia.TabIndex = 26;
            // 
            // labelNjesia
            // 
            this.labelNjesia.AutoSize = true;
            this.labelNjesia.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelNjesia.Location = new System.Drawing.Point(12, 332);
            this.labelNjesia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNjesia.Name = "labelNjesia";
            this.labelNjesia.Size = new System.Drawing.Size(135, 25);
            this.labelNjesia.TabIndex = 16;
            this.labelNjesia.Text = "Njesia matese";
            // 
            // labelKategoria
            // 
            this.labelKategoria.AutoSize = true;
            this.labelKategoria.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelKategoria.Location = new System.Drawing.Point(12, 400);
            this.labelKategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKategoria.Name = "labelKategoria";
            this.labelKategoria.Size = new System.Drawing.Size(96, 25);
            this.labelKategoria.TabIndex = 14;
            this.labelKategoria.Text = "Kategoria";
            // 
            // shtoArtikull
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 585);
            this.Controls.Add(this.groupBoxTedhenatEArtikullit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonShtoArtikull);
            this.Controls.Add(this.buttonNdryshoArtikull);
            this.Controls.Add(this.groupBoxArtikujtEkzistues);
            this.Name = "shtoArtikull";
            this.Text = "shtoArtikull";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtikullList)).EndInit();
            this.groupBoxArtikujtEkzistues.ResumeLayout(false);
            this.groupBoxArtikujtEkzistues.PerformLayout();
            this.groupBoxTedhenatEArtikullit.ResumeLayout(false);
            this.groupBoxTedhenatEArtikullit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogFature;
        private System.Drawing.Printing.PrintDocument printDocumentFature;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonShtoArtikull;
        private System.Windows.Forms.Button buttonNdryshoArtikull;
        private System.Windows.Forms.TextBox textBoxKerko;
        private System.Windows.Forms.Label labelKerkoSipasID;
        private System.Windows.Forms.DataGridView dataGridViewArtikullList;
        private System.Windows.Forms.GroupBox groupBoxArtikujtEkzistues;
        private System.Windows.Forms.GroupBox groupBoxTedhenatEArtikullit;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.ComboBox comboBoxKategori;
        private System.Windows.Forms.ComboBox comboBoxNjesia;
        private System.Windows.Forms.Label labelNjesia;
        private System.Windows.Forms.Label labelKategoria;
        private System.Windows.Forms.TextBox textBoxArtikulli;
        private System.Windows.Forms.Label labelArtikulli;
        private System.Windows.Forms.TextBox textBoxCmimi;
        private System.Windows.Forms.Label labelCmimi;
        private System.Windows.Forms.TextBox textBoxSasia;
        private System.Windows.Forms.Label labelSasia;
        private System.Windows.Forms.CheckBox nonActive;
        private System.Windows.Forms.CheckBox active;
        private System.Windows.Forms.Label labelStatus;
    }
}