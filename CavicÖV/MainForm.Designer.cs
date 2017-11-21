namespace CavicÖV
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.lblAbfahrt = new System.Windows.Forms.Label();
            this.lblAnkunft = new System.Windows.Forms.Label();
            this.btnSuchen = new System.Windows.Forms.Button();
            this.btnAbfahrtstafel = new System.Windows.Forms.Button();
            this.btnStationAbfahrtSuchen = new System.Windows.Forms.Button();
            this.btnStationAnkunftSuchen = new System.Windows.Forms.Button();
            this.btnOrten = new System.Windows.Forms.Button();
            this.dgvVerbindungen = new System.Windows.Forms.DataGridView();
            this.autoSucheAbfahrt = new CavicÖV.autoSuche();
            this.autoSucheAnkunft = new CavicÖV.autoSuche();
            this.dateTimePickerAll = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerbindungen)).BeginInit();
            this.SuspendLayout();
            // 
            // pctLogo
            // 
            this.pctLogo.Image = global::CavicÖV.Properties.Resources.navigation_logo_md_iloveimg_resized;
            this.pctLogo.Location = new System.Drawing.Point(5, 12);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(156, 150);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctLogo.TabIndex = 0;
            this.pctLogo.TabStop = false;
            // 
            // lblAbfahrt
            // 
            this.lblAbfahrt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAbfahrt.AutoSize = true;
            this.lblAbfahrt.Location = new System.Drawing.Point(212, 15);
            this.lblAbfahrt.Name = "lblAbfahrt";
            this.lblAbfahrt.Size = new System.Drawing.Size(78, 17);
            this.lblAbfahrt.TabIndex = 1;
            this.lblAbfahrt.Text = "Abfahrtsort";
            // 
            // lblAnkunft
            // 
            this.lblAnkunft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnkunft.AutoSize = true;
            this.lblAnkunft.Location = new System.Drawing.Point(647, 15);
            this.lblAnkunft.Name = "lblAnkunft";
            this.lblAnkunft.Size = new System.Drawing.Size(80, 17);
            this.lblAnkunft.TabIndex = 2;
            this.lblAnkunft.Text = "Ankunftsort";
            // 
            // btnSuchen
            // 
            this.btnSuchen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuchen.AutoSize = true;
            this.btnSuchen.Enabled = false;
            this.btnSuchen.Location = new System.Drawing.Point(483, 35);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(158, 38);
            this.btnSuchen.TabIndex = 3;
            this.btnSuchen.Text = "Suchen";
            this.btnSuchen.UseVisualStyleBackColor = true;
            this.btnSuchen.Click += new System.EventHandler(this.btnSuch_Click);
            // 
            // btnAbfahrtstafel
            // 
            this.btnAbfahrtstafel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbfahrtstafel.AutoSize = true;
            this.btnAbfahrtstafel.Enabled = false;
            this.btnAbfahrtstafel.Location = new System.Drawing.Point(5, 217);
            this.btnAbfahrtstafel.Name = "btnAbfahrtstafel";
            this.btnAbfahrtstafel.Size = new System.Drawing.Size(156, 27);
            this.btnAbfahrtstafel.TabIndex = 5;
            this.btnAbfahrtstafel.Text = "Abfahrtstafel";
            this.btnAbfahrtstafel.UseVisualStyleBackColor = true;
            this.btnAbfahrtstafel.Click += new System.EventHandler(this.btnAbfahrtstafel_Click);
            // 
            // btnStationAbfahrtSuchen
            // 
            this.btnStationAbfahrtSuchen.Enabled = false;
            this.btnStationAbfahrtSuchen.Location = new System.Drawing.Point(376, 6);
            this.btnStationAbfahrtSuchen.Name = "btnStationAbfahrtSuchen";
            this.btnStationAbfahrtSuchen.Size = new System.Drawing.Size(101, 25);
            this.btnStationAbfahrtSuchen.TabIndex = 6;
            this.btnStationAbfahrtSuchen.Text = "Wo station?";
            this.btnStationAbfahrtSuchen.UseVisualStyleBackColor = true;
            this.btnStationAbfahrtSuchen.Click += new System.EventHandler(this.btnStationAbfahrtSuchen_Click_1);
            // 
            // btnStationAnkunftSuchen
            // 
            this.btnStationAnkunftSuchen.Enabled = false;
            this.btnStationAnkunftSuchen.Location = new System.Drawing.Point(843, 5);
            this.btnStationAnkunftSuchen.Name = "btnStationAnkunftSuchen";
            this.btnStationAnkunftSuchen.Size = new System.Drawing.Size(101, 25);
            this.btnStationAnkunftSuchen.TabIndex = 7;
            this.btnStationAnkunftSuchen.Text = "Wo station?";
            this.btnStationAnkunftSuchen.UseVisualStyleBackColor = true;
            this.btnStationAnkunftSuchen.Click += new System.EventHandler(this.btnStationAnkunftSuchen_Click);
            // 
            // btnOrten
            // 
            this.btnOrten.Location = new System.Drawing.Point(215, 63);
            this.btnOrten.Name = "btnOrten";
            this.btnOrten.Size = new System.Drawing.Size(75, 23);
            this.btnOrten.TabIndex = 8;
            this.btnOrten.Text = "Orten";
            this.btnOrten.UseVisualStyleBackColor = true;
            this.btnOrten.Click += new System.EventHandler(this.btnOrten_Click);
            // 
            // dgvVerbindungen
            // 
            this.dgvVerbindungen.AllowUserToAddRows = false;
            this.dgvVerbindungen.AllowUserToDeleteRows = false;
            this.dgvVerbindungen.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvVerbindungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerbindungen.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvVerbindungen.Location = new System.Drawing.Point(215, 102);
            this.dgvVerbindungen.Name = "dgvVerbindungen";
            this.dgvVerbindungen.ReadOnly = true;
            this.dgvVerbindungen.RowTemplate.Height = 24;
            this.dgvVerbindungen.Size = new System.Drawing.Size(729, 253);
            this.dgvVerbindungen.TabIndex = 17;
            this.dgvVerbindungen.TabStop = false;
            // 
            // autoSucheAbfahrt
            // 
            this.autoSucheAbfahrt.Location = new System.Drawing.Point(215, 35);
            this.autoSucheAbfahrt.Name = "autoSucheAbfahrt";
            this.autoSucheAbfahrt.Size = new System.Drawing.Size(262, 22);
            this.autoSucheAbfahrt.TabIndex = 1;
            // 
            // autoSucheAnkunft
            // 
            this.autoSucheAnkunft.Location = new System.Drawing.Point(647, 35);
            this.autoSucheAnkunft.Name = "autoSucheAnkunft";
            this.autoSucheAnkunft.Size = new System.Drawing.Size(297, 22);
            this.autoSucheAnkunft.TabIndex = 2;
            // 
            // dateTimePickerAll
            // 
            this.dateTimePickerAll.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dateTimePickerAll.CustomFormat = "d.MM.yyyy    HH:mm";
            this.dateTimePickerAll.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAll.Location = new System.Drawing.Point(788, 74);
            this.dateTimePickerAll.Name = "dateTimePickerAll";
            this.dateTimePickerAll.ShowUpDown = true;
            this.dateTimePickerAll.Size = new System.Drawing.Size(156, 22);
            this.dateTimePickerAll.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(699, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Abfahrtszeit";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(333, 379);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 23;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(468, 380);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 24;
            this.textBox2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(617, 380);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 25;
            this.textBox3.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1012, 453);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerAll);
            this.Controls.Add(this.autoSucheAnkunft);
            this.Controls.Add(this.autoSucheAbfahrt);
            this.Controls.Add(this.dgvVerbindungen);
            this.Controls.Add(this.btnOrten);
            this.Controls.Add(this.btnStationAnkunftSuchen);
            this.Controls.Add(this.btnStationAbfahrtSuchen);
            this.Controls.Add(this.btnAbfahrtstafel);
            this.Controls.Add(this.btnSuchen);
            this.Controls.Add(this.lblAnkunft);
            this.Controls.Add(this.lblAbfahrt);
            this.Controls.Add(this.pctLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1030, 500);
            this.MinimumSize = new System.Drawing.Size(1030, 500);
            this.Name = "MainForm";
            this.Text = "CavicÖV";
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerbindungen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Label lblAbfahrt;
        private System.Windows.Forms.Label lblAnkunft;
        private System.Windows.Forms.Button btnSuchen;
        private System.Windows.Forms.Button btnAbfahrtstafel;
        private System.Windows.Forms.Button btnStationAbfahrtSuchen;
        private System.Windows.Forms.Button btnStationAnkunftSuchen;
        private System.Windows.Forms.Button btnOrten;
        private System.Windows.Forms.DataGridView dgvVerbindungen;
        private autoSuche autoSucheAbfahrt;
        private autoSuche autoSucheAnkunft;
        private System.Windows.Forms.DateTimePicker dateTimePickerAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

