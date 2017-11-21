using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace CavicÖV
{
    public partial class autoSuche : UserControl
    {
        /// <summary>
        /// Event onEnterPressed wird eingebunden in das MainForm.
        /// </summary>
        public event EventHandler onEnterPressed;

        /// <summary>
        /// Gibt den Text aus der Textbox zurück.
        /// </summary>
        public string text { get { return txtSuchen.Text; } }
        public autoSuche()
        {
            InitializeComponent();

        }


        /// <summary>
        /// Gibt die Möglichkeit ein Abonnement zu erstellen mit jedem Event.
        /// </summary>
        /// <returns></returns>
        public TextBox getTextBox()
        {
            return this.txtSuchen;
        }

        private void autoSuche_Load(object sender, EventArgs e)
        {
            /*Höhe gleich setzen, damit man nichts sieht(DropDown).*/
            this.Height = txtSuchen.Height;
        }

        private void txtSuchen_TextChanged(object sender, EventArgs e)
        {
            /*TextBox darf nicht leer sein und dann geht man in die else-Anweisung.*/
            if (string.IsNullOrWhiteSpace(txtSuchen.Text))
            {
                this.Height = txtSuchen.Height;
            }
            else
            {
                Transport trans = new Transport();
                /*In den Vordergrundbringen.*/
                this.BringToFront();
                this.Height = 150;
                listSuchen.Items.Clear();
                Stations stat = trans.GetStations(txtSuchen.Text);
                foreach (Station stati in stat.StationList)
                {
                    listSuchen.Items.Add(stati.Name);
                }
            }
        }

        private void listSuchen_Leave(object sender, EventArgs e)
        {
            this.Height = txtSuchen.Height;
        }

        private void listSuchen_KeyDown(object sender, KeyEventArgs e)
        {
            /*Wenn Enter gedrückt worden ist.*/
            if (e.KeyCode == Keys.Enter)
            {
                if (listSuchen.SelectedItem != null)
                {
                    txtSuchen.Text = listSuchen.SelectedItem.ToString();
                    this.Height = txtSuchen.Height;
                }

                if (onEnterPressed != null)
                {
                    onEnterPressed(this, null);
                }

                this.txtSuchen.Focus();
            }
        }

        private void txtSuchen_KeyDown(object sender, KeyEventArgs e)
        {  /*In die List Box springen mit (Pfeil nach unten Taste).*/
            if (e.KeyCode == Keys.Down)
            {
                listSuchen.Focus();
                if (listSuchen.Items.Count > 0)
                {
                    listSuchen.SelectedItem = listSuchen.Items[0];
                }
            }
        }

        private void listSuchen_MouseClick(object sender, MouseEventArgs e)
        {
            txtSuchen.Text = listSuchen.SelectedItem.ToString();
            this.Height = txtSuchen.Height;
        }
    }
}
