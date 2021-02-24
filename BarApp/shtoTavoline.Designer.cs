using System;

namespace BarApp
{
    partial class shtoTavoline
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
            this.comboBoxKamarier = new System.Windows.Forms.ComboBox();
            this.labelKamarier = new System.Windows.Forms.Label();
            this.buttonNdrysho = new System.Windows.Forms.Button();
            this.groupBoxTavolinatEkzistuese = new System.Windows.Forms.GroupBox();
            this.dataGridViewTavolinaList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.groupBoxTavolinatEkzistuese.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTavolinaList)).BeginInit();
            this.SuspendLayout();
            // 
            // nonActive
            // 
            this.nonActive.AutoSize = true;
            this.nonActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nonActive.Location = new System.Drawing.Point(322, 105);
            this.nonActive.Margin = new System.Windows.Forms.Padding(4);
            this.nonActive.Name = "nonActive";
            this.nonActive.Size = new System.Drawing.Size(101, 29);
            this.nonActive.TabIndex = 45;
            this.nonActive.Text = "Jo aktiv";
            this.nonActive.UseVisualStyleBackColor = true;
            // 
            // active
            // 
            this.active.AutoSize = true;
            this.active.Checked = true;
            this.active.CheckState = System.Windows.Forms.CheckState.Checked;
            this.active.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.active.Location = new System.Drawing.Point(213, 104);
            this.active.Margin = new System.Windows.Forms.Padding(4);
            this.active.Name = "active";
            this.active.Size = new System.Drawing.Size(77, 29);
            this.active.TabIndex = 44;
            this.active.Text = "Aktiv";
            this.active.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(13, 99);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 34);
            this.label10.TabIndex = 43;
            this.label10.Text = "Status";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // shtoBtn
            // 
            this.shtoBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.shtoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.shtoBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.shtoBtn.Location = new System.Drawing.Point(477, 17);
            this.shtoBtn.Margin = new System.Windows.Forms.Padding(4);
            this.shtoBtn.Name = "shtoBtn";
            this.shtoBtn.Size = new System.Drawing.Size(134, 58);
            this.shtoBtn.TabIndex = 42;
            this.shtoBtn.Text = "Shto";
            this.shtoBtn.UseVisualStyleBackColor = false;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Orange;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.clearBtn.Location = new System.Drawing.Point(635, 17);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(134, 58);
            this.clearBtn.TabIndex = 41;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            // 
            // comboBoxKamarier
            // 
            this.comboBoxKamarier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxKamarier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxKamarier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxKamarier.FormattingEnabled = true;
            this.comboBoxKamarier.Location = new System.Drawing.Point(162, 63);
            this.comboBoxKamarier.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxKamarier.Name = "comboBoxKamarier";
            this.comboBoxKamarier.Size = new System.Drawing.Size(277, 33);
            this.comboBoxKamarier.TabIndex = 47;
            // 
            // labelKamarier
            // 
            this.labelKamarier.AutoSize = true;
            this.labelKamarier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelKamarier.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelKamarier.Location = new System.Drawing.Point(13, 63);
            this.labelKamarier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKamarier.Name = "labelKamarier";
            this.labelKamarier.Size = new System.Drawing.Size(95, 25);
            this.labelKamarier.TabIndex = 46;
            this.labelKamarier.Text = "Kamarieri";
            // 
            // buttonNdrysho
            // 
            this.buttonNdrysho.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonNdrysho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNdrysho.ForeColor = System.Drawing.Color.White;
            this.buttonNdrysho.Location = new System.Drawing.Point(534, 89);
            this.buttonNdrysho.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNdrysho.Name = "buttonNdrysho";
            this.buttonNdrysho.Size = new System.Drawing.Size(187, 55);
            this.buttonNdrysho.TabIndex = 48;
            this.buttonNdrysho.Text = "Ndrysho";
            this.buttonNdrysho.UseVisualStyleBackColor = false;
            // 
            // groupBoxTavolinatEkzistuese
            // 
            this.groupBoxTavolinatEkzistuese.Controls.Add(this.dataGridViewTavolinaList);
            this.groupBoxTavolinatEkzistuese.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTavolinatEkzistuese.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBoxTavolinatEkzistuese.Location = new System.Drawing.Point(3, 161);
            this.groupBoxTavolinatEkzistuese.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxTavolinatEkzistuese.Name = "groupBoxTavolinatEkzistuese";
            this.groupBoxTavolinatEkzistuese.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxTavolinatEkzistuese.Size = new System.Drawing.Size(784, 277);
            this.groupBoxTavolinatEkzistuese.TabIndex = 49;
            this.groupBoxTavolinatEkzistuese.TabStop = false;
            this.groupBoxTavolinatEkzistuese.Text = "Tavolina ekzistuese";
            // 
            // dataGridViewTavolinaList
            // 
            this.dataGridViewTavolinaList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTavolinaList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTavolinaList.Location = new System.Drawing.Point(8, 31);
            this.dataGridViewTavolinaList.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewTavolinaList.Name = "dataGridViewTavolinaList";
            this.dataGridViewTavolinaList.Size = new System.Drawing.Size(768, 238);
            this.dataGridViewTavolinaList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 25);
            this.label1.TabIndex = 50;
            this.label1.Text = "ID";
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxId.Location = new System.Drawing.Point(162, 13);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(277, 30);
            this.textBoxId.TabIndex = 51;
            // 
            // shtoTavoline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxTavolinatEkzistuese);
            this.Controls.Add(this.buttonNdrysho);
            this.Controls.Add(this.comboBoxKamarier);
            this.Controls.Add(this.labelKamarier);
            this.Controls.Add(this.nonActive);
            this.Controls.Add(this.active);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.shtoBtn);
            this.Controls.Add(this.clearBtn);
            this.Name = "shtoTavoline";
            this.Text = "tavolina";
            this.Load += new System.EventHandler(this.shtoTavoline_Load);
            this.groupBoxTavolinatEkzistuese.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTavolinaList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox nonActive;
        private System.Windows.Forms.CheckBox active;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button shtoBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.ComboBox comboBoxKamarier;
        private System.Windows.Forms.Label labelKamarier;
        private System.Windows.Forms.Button buttonNdrysho;
        private System.Windows.Forms.GroupBox groupBoxTavolinatEkzistuese;
        private System.Windows.Forms.DataGridView dataGridViewTavolinaList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxId;

        public EventHandler labelKamarier_Click { get; private set; }
    }
}