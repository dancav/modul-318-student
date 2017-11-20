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
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblZeit = new System.Windows.Forms.Label();
            this.comAbfahrt = new System.Windows.Forms.ComboBox();
            this.comAnkunft = new System.Windows.Forms.ComboBox();
            this.btnSuchen = new System.Windows.Forms.Button();
            this.btnAbfahrtSuchen = new System.Windows.Forms.Button();
            this.btnAnkunftSuchen = new System.Windows.Forms.Button();
            this.btnAbfahrtstafel = new System.Windows.Forms.Button();
            this.btnStationAbfahrtSuchen = new System.Windows.Forms.Button();
            this.btnStationAnkunftSuchen = new System.Windows.Forms.Button();
            this.btnOrten = new System.Windows.Forms.Button();
            this.dgvVerbindungen = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerbindungen)).BeginInit();
            this.SuspendLayout();
            // 
            // pctLogo
            // 
            this.pctLogo.Image = global::CavicÖV.Properties.Resources.navigation_logo_md_iloveimg_resized;
            this.pctLogo.Location = new System.Drawing.Point(5, 5);
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
            this.lblAbfahrt.Location = new System.Drawing.Point(274, 6);
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
            this.lblAnkunft.Location = new System.Drawing.Point(660, 9);
            this.lblAnkunft.Name = "lblAnkunft";
            this.lblAnkunft.Size = new System.Drawing.Size(80, 17);
            this.lblAnkunft.TabIndex = 2;
            this.lblAnkunft.Text = "Ankunftsort";
            // 
            // datePicker
            // 
            this.datePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(277, 87);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(272, 22);
            this.datePicker.TabIndex = 4;
            // 
            // timePicker
            // 
            this.timePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(663, 87);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(273, 22);
            this.timePicker.TabIndex = 3;
            this.timePicker.Value = new System.DateTime(2017, 11, 15, 13, 56, 0, 0);
            // 
            // lblDatum
            // 
            this.lblDatum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(274, 67);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(49, 17);
            this.lblDatum.TabIndex = 8;
            this.lblDatum.Text = "Datum";
            // 
            // lblZeit
            // 
            this.lblZeit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblZeit.AutoSize = true;
            this.lblZeit.Location = new System.Drawing.Point(660, 67);
            this.lblZeit.Name = "lblZeit";
            this.lblZeit.Size = new System.Drawing.Size(53, 17);
            this.lblZeit.TabIndex = 9;
            this.lblZeit.Text = "Uhrzeit";
            // 
            // comAbfahrt
            // 
            this.comAbfahrt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comAbfahrt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comAbfahrt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comAbfahrt.FormattingEnabled = true;
            this.comAbfahrt.Location = new System.Drawing.Point(277, 26);
            this.comAbfahrt.Name = "comAbfahrt";
            this.comAbfahrt.Size = new System.Drawing.Size(250, 24);
            this.comAbfahrt.TabIndex = 0;
            // 
            // comAnkunft
            // 
            this.comAnkunft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comAnkunft.FormattingEnabled = true;
            this.comAnkunft.Location = new System.Drawing.Point(663, 26);
            this.comAnkunft.Name = "comAnkunft";
            this.comAnkunft.Size = new System.Drawing.Size(225, 24);
            this.comAnkunft.TabIndex = 1;
            // 
            // btnSuchen
            // 
            this.btnSuchen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuchen.AutoSize = true;
            this.btnSuchen.Location = new System.Drawing.Point(492, 117);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(248, 38);
            this.btnSuchen.TabIndex = 2;
            this.btnSuchen.Text = "Suchen";
            this.btnSuchen.UseVisualStyleBackColor = true;
            this.btnSuchen.Click += new System.EventHandler(this.btnSuch_Click);
            // 
            // btnAbfahrtSuchen
            // 
            this.btnAbfahrtSuchen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbfahrtSuchen.AutoSize = true;
            this.btnAbfahrtSuchen.Location = new System.Drawing.Point(12, 324);
            this.btnAbfahrtSuchen.Name = "btnAbfahrtSuchen";
            this.btnAbfahrtSuchen.Size = new System.Drawing.Size(231, 28);
            this.btnAbfahrtSuchen.TabIndex = 5;
            this.btnAbfahrtSuchen.Text = "Abfahrt suchen";
            this.btnAbfahrtSuchen.UseVisualStyleBackColor = true;
            this.btnAbfahrtSuchen.Click += new System.EventHandler(this.btnAbfahrtSuchen_Click);
            // 
            // btnAnkunftSuchen
            // 
            this.btnAnkunftSuchen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnkunftSuchen.AutoSize = true;
            this.btnAnkunftSuchen.Location = new System.Drawing.Point(-2, 379);
            this.btnAnkunftSuchen.Name = "btnAnkunftSuchen";
            this.btnAnkunftSuchen.Size = new System.Drawing.Size(273, 28);
            this.btnAnkunftSuchen.TabIndex = 6;
            this.btnAnkunftSuchen.Text = "Ankunft suchen";
            this.btnAnkunftSuchen.UseVisualStyleBackColor = true;
            this.btnAnkunftSuchen.Click += new System.EventHandler(this.btnAnkunftSuchen_Click);
            // 
            // btnAbfahrtstafel
            // 
            this.btnAbfahrtstafel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbfahrtstafel.AutoSize = true;
            this.btnAbfahrtstafel.Location = new System.Drawing.Point(5, 175);
            this.btnAbfahrtstafel.Name = "btnAbfahrtstafel";
            this.btnAbfahrtstafel.Size = new System.Drawing.Size(140, 27);
            this.btnAbfahrtstafel.TabIndex = 11;
            this.btnAbfahrtstafel.Text = "Abfahrtstafel";
            this.btnAbfahrtstafel.UseVisualStyleBackColor = true;
            this.btnAbfahrtstafel.Click += new System.EventHandler(this.btnAbfahrtstafel_Click);
            // 
            // btnStationAbfahrtSuchen
            // 
            this.btnStationAbfahrtSuchen.Location = new System.Drawing.Point(167, 26);
            this.btnStationAbfahrtSuchen.Name = "btnStationAbfahrtSuchen";
            this.btnStationAbfahrtSuchen.Size = new System.Drawing.Size(104, 32);
            this.btnStationAbfahrtSuchen.TabIndex = 13;
            this.btnStationAbfahrtSuchen.Text = "Wo station?";
            this.btnStationAbfahrtSuchen.UseVisualStyleBackColor = true;
            this.btnStationAbfahrtSuchen.Click += new System.EventHandler(this.btnStationAbfahrtSuchen_Click_1);
            // 
            // btnStationAnkunftSuchen
            // 
            this.btnStationAnkunftSuchen.Location = new System.Drawing.Point(894, 21);
            this.btnStationAnkunftSuchen.Name = "btnStationAnkunftSuchen";
            this.btnStationAnkunftSuchen.Size = new System.Drawing.Size(104, 32);
            this.btnStationAnkunftSuchen.TabIndex = 14;
            this.btnStationAnkunftSuchen.Text = "Wo station?";
            this.btnStationAnkunftSuchen.UseVisualStyleBackColor = true;
            this.btnStationAnkunftSuchen.Click += new System.EventHandler(this.btnStationAnkunftSuchen_Click);
            // 
            // btnOrten
            // 
            this.btnOrten.Location = new System.Drawing.Point(534, 26);
            this.btnOrten.Name = "btnOrten";
            this.btnOrten.Size = new System.Drawing.Size(75, 23);
            this.btnOrten.TabIndex = 15;
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
            this.dgvVerbindungen.Location = new System.Drawing.Point(287, 172);
            this.dgvVerbindungen.Name = "dgvVerbindungen";
            this.dgvVerbindungen.ReadOnly = true;
            this.dgvVerbindungen.RowTemplate.Height = 24;
            this.dgvVerbindungen.Size = new System.Drawing.Size(634, 253);
            this.dgvVerbindungen.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1012, 453);
            this.Controls.Add(this.dgvVerbindungen);
            this.Controls.Add(this.btnOrten);
            this.Controls.Add(this.btnStationAnkunftSuchen);
            this.Controls.Add(this.btnStationAbfahrtSuchen);
            this.Controls.Add(this.btnAbfahrtstafel);
            this.Controls.Add(this.btnAnkunftSuchen);
            this.Controls.Add(this.btnAbfahrtSuchen);
            this.Controls.Add(this.btnSuchen);
            this.Controls.Add(this.comAnkunft);
            this.Controls.Add(this.comAbfahrt);
            this.Controls.Add(this.lblZeit);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.datePicker);
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
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblZeit;
        private System.Windows.Forms.ComboBox comAbfahrt;
        private System.Windows.Forms.ComboBox comAnkunft;
        private System.Windows.Forms.Button btnSuchen;
        private System.Windows.Forms.Button btnAbfahrtSuchen;
        private System.Windows.Forms.Button btnAnkunftSuchen;
        private System.Windows.Forms.Button btnAbfahrtstafel;
        private System.Windows.Forms.Button btnStationAbfahrtSuchen;
        private System.Windows.Forms.Button btnStationAnkunftSuchen;
        private System.Windows.Forms.Button btnOrten;
        private System.Windows.Forms.DataGridView dgvVerbindungen;
    }
}

