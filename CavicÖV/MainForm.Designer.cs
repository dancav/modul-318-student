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
            this.btnSuchen = new System.Windows.Forms.DateTimePicker();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblZeit = new System.Windows.Forms.Label();
            this.listVerbindungen = new System.Windows.Forms.ListBox();
            this.comAbfahrt = new System.Windows.Forms.ComboBox();
            this.comAnkunft = new System.Windows.Forms.ComboBox();
            this.btnSuch = new System.Windows.Forms.Button();
            this.btnAbfahrtSuchen = new System.Windows.Forms.Button();
            this.btnAnkunftSuchen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
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
            this.lblAbfahrt.Location = new System.Drawing.Point(237, 6);
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
            this.lblAnkunft.Location = new System.Drawing.Point(493, 6);
            this.lblAnkunft.Name = "lblAnkunft";
            this.lblAnkunft.Size = new System.Drawing.Size(80, 17);
            this.lblAnkunft.TabIndex = 2;
            this.lblAnkunft.Text = "Ankunftsort";
            // 
            // btnSuchen
            // 
            this.btnSuchen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSuchen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.btnSuchen.Location = new System.Drawing.Point(240, 87);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(112, 22);
            this.btnSuchen.TabIndex = 7;
            // 
            // timePicker
            // 
            this.timePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(496, 87);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(112, 22);
            this.timePicker.TabIndex = 6;
            this.timePicker.Value = new System.DateTime(2017, 11, 15, 13, 56, 0, 0);
            // 
            // lblDatum
            // 
            this.lblDatum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(237, 67);
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
            this.lblZeit.Location = new System.Drawing.Point(493, 67);
            this.lblZeit.Name = "lblZeit";
            this.lblZeit.Size = new System.Drawing.Size(53, 17);
            this.lblZeit.TabIndex = 9;
            this.lblZeit.Text = "Uhrzeit";
            // 
            // listVerbindungen
            // 
            this.listVerbindungen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listVerbindungen.FormattingEnabled = true;
            this.listVerbindungen.ItemHeight = 16;
            this.listVerbindungen.Location = new System.Drawing.Point(240, 139);
            this.listVerbindungen.Name = "listVerbindungen";
            this.listVerbindungen.Size = new System.Drawing.Size(306, 196);
            this.listVerbindungen.TabIndex = 10;
            // 
            // comAbfahrt
            // 
            this.comAbfahrt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comAbfahrt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comAbfahrt.FormattingEnabled = true;
            this.comAbfahrt.Location = new System.Drawing.Point(240, 25);
            this.comAbfahrt.Name = "comAbfahrt";
            this.comAbfahrt.Size = new System.Drawing.Size(140, 24);
            this.comAbfahrt.TabIndex = 11;
            this.comAbfahrt.SelectedIndexChanged += new System.EventHandler(this.comAbfahrt_SelectedIndexChanged);
            // 
            // comAnkunft
            // 
            this.comAnkunft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comAnkunft.FormattingEnabled = true;
            this.comAnkunft.Location = new System.Drawing.Point(496, 26);
            this.comAnkunft.Name = "comAnkunft";
            this.comAnkunft.Size = new System.Drawing.Size(124, 24);
            this.comAnkunft.TabIndex = 12;
            // 
            // btnSuch
            // 
            this.btnSuch.Location = new System.Drawing.Point(369, 102);
            this.btnSuch.Name = "btnSuch";
            this.btnSuch.Size = new System.Drawing.Size(109, 31);
            this.btnSuch.TabIndex = 13;
            this.btnSuch.Text = "Suchen";
            this.btnSuch.UseVisualStyleBackColor = true;
            this.btnSuch.Click += new System.EventHandler(this.btnSuch_Click);
            // 
            // btnAbfahrtSuchen
            // 
            this.btnAbfahrtSuchen.Location = new System.Drawing.Point(240, 341);
            this.btnAbfahrtSuchen.Name = "btnAbfahrtSuchen";
            this.btnAbfahrtSuchen.Size = new System.Drawing.Size(112, 30);
            this.btnAbfahrtSuchen.TabIndex = 14;
            this.btnAbfahrtSuchen.Text = "Abfahrt suchen";
            this.btnAbfahrtSuchen.UseVisualStyleBackColor = true;
            this.btnAbfahrtSuchen.Click += new System.EventHandler(this.btnAbfahrtSuchen_Click);
            // 
            // btnAnkunftSuchen
            // 
            this.btnAnkunftSuchen.Location = new System.Drawing.Point(496, 341);
            this.btnAnkunftSuchen.Name = "btnAnkunftSuchen";
            this.btnAnkunftSuchen.Size = new System.Drawing.Size(124, 30);
            this.btnAnkunftSuchen.TabIndex = 15;
            this.btnAnkunftSuchen.Text = "Ankunft suchen";
            this.btnAnkunftSuchen.UseVisualStyleBackColor = true;
            this.btnAnkunftSuchen.Click += new System.EventHandler(this.btnAnkunftSuchen_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 383);
            this.Controls.Add(this.btnAnkunftSuchen);
            this.Controls.Add(this.btnAbfahrtSuchen);
            this.Controls.Add(this.btnSuch);
            this.Controls.Add(this.comAnkunft);
            this.Controls.Add(this.comAbfahrt);
            this.Controls.Add(this.listVerbindungen);
            this.Controls.Add(this.lblZeit);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.btnSuchen);
            this.Controls.Add(this.lblAnkunft);
            this.Controls.Add(this.lblAbfahrt);
            this.Controls.Add(this.pctLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "CavicÖV";
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Label lblAbfahrt;
        private System.Windows.Forms.Label lblAnkunft;
        private System.Windows.Forms.DateTimePicker btnSuchen;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblZeit;
        private System.Windows.Forms.ListBox listVerbindungen;
        private System.Windows.Forms.ComboBox comAbfahrt;
        private System.Windows.Forms.ComboBox comAnkunft;
        private System.Windows.Forms.Button btnSuch;
        private System.Windows.Forms.Button btnAbfahrtSuchen;
        private System.Windows.Forms.Button btnAnkunftSuchen;
    }
}

