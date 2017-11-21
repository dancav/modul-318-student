namespace CavicÖV
{
    partial class autoSuche
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.listSuchen = new System.Windows.Forms.ListBox();
            this.txtSuchen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listSuchen
            // 
            this.listSuchen.FormattingEnabled = true;
            this.listSuchen.ItemHeight = 16;
            this.listSuchen.Location = new System.Drawing.Point(0, 25);
            this.listSuchen.Margin = new System.Windows.Forms.Padding(0);
            this.listSuchen.Name = "listSuchen";
            this.listSuchen.Size = new System.Drawing.Size(297, 308);
            this.listSuchen.TabIndex = 0;
            this.listSuchen.TabStop = false;
            this.listSuchen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listSuchen_MouseClick);
            this.listSuchen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listSuchen_KeyDown);
            this.listSuchen.Leave += new System.EventHandler(this.listSuchen_Leave);
            // 
            // txtSuchen
            // 
            this.txtSuchen.Location = new System.Drawing.Point(0, 0);
            this.txtSuchen.Name = "txtSuchen";
            this.txtSuchen.Size = new System.Drawing.Size(297, 22);
            this.txtSuchen.TabIndex = 1;
            this.txtSuchen.TextChanged += new System.EventHandler(this.txtSuchen_TextChanged);
            this.txtSuchen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSuchen_KeyDown);
            // 
            // autoSuche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listSuchen);
            this.Controls.Add(this.txtSuchen);
            this.Name = "autoSuche";
            this.Size = new System.Drawing.Size(297, 323);
            this.Load += new System.EventHandler(this.autoSuche_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listSuchen;
        private System.Windows.Forms.TextBox txtSuchen;
    }
}
