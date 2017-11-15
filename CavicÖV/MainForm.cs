using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace CavicÖV
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void btnSuch_Click(object sender, EventArgs e)
        {
            Transport verbindung = new Transport();
            Connections strecke = verbindung.GetConnections(comAbfahrt.Text, comAnkunft.Text);

            foreach (Connection c in strecke.ConnectionList)
            {
                string dauer = string.Format("{hh:mm}", c.Duration);
                comAbfahrt.Items.Add(dauer);
            }


        }

        private void comAbfahrt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAbfahrtSuchen_Click(object sender, EventArgs e)
        {
            try
            {
                comAbfahrt.Items.Clear();
                Transport station = new Transport();

                /*Station wird abgefragt*/
                var a = station.GetStations(comAbfahrt.Text);
                foreach (var item in a.StationList)
                {
                    comAbfahrt.Items.Add(item.Name);
                }
            }
            catch
            {
                MessageBox.Show("Es ist ein Fehler aufgetreten. \nBitte versuchen Sie es nochmals, falls es dann nicht geht, wenden Sie sich bei unserem Kundendienst. ");
            }

        }

        private void btnAnkunftSuchen_Click(object sender, EventArgs e)
        {
            try
            {
                comAnkunft.Items.Clear();
                Transport station = new Transport();

                /*Station wird abgefragt*/
                var b = station.GetStations(comAnkunft.Text);
                foreach (var item in b.StationList)
                {
                    comAnkunft.Items.Add(item.Name);
                }
            }
            catch
            {
                MessageBox.Show("Es ist ein Fehler aufgetreten. \nBitte versuchen Sie es nochmals, falls es dann nicht geht, wenden Sie sich bei unserem Kundendienst. ");
            }
        }
    }
}
