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
using System.Device.Location;

namespace CavicÖV
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            timePicker.CustomFormat = "HH:mm";
            timePicker.Text = Convert.ToString(DateTime.Now.Hour + ":" + DateTime.Now.Minute);

        }

        private void btnSuch_Click(object sender, EventArgs e)
        {
            Transport verbindung = new Transport();
            Connections strecke = verbindung.GetConnections(comAbfahrt.Text, comAnkunft.Text, datePicker.Text, timePicker.Text);
            List<MeineVerbindungen> meineVerbindungen = new List<MeineVerbindungen>();

            foreach (Connection c in strecke.ConnectionList)
            {

                MeineVerbindungen mv = new MeineVerbindungen(c.Duration, c.From.Departure, c.To.Arrival, c.From.Delay);


                mv.arrival = zeitFormatierer(mv.arrival, "HH:mm");
                mv.departure = zeitFormatierer(mv.departure, "HH:mm");
                mv.duration = mv.duration.Substring(3, 5);
                meineVerbindungen.Add(mv);
                dgvVerbindungen.DataSource = meineVerbindungen;
                dgvVerbindungen.Columns[0].HeaderText = "Dauer";
                dgvVerbindungen.Columns[1].HeaderText = "Abfahrtszeit";
                dgvVerbindungen.Columns[2].HeaderText = "Ankunftszeit";
                dgvVerbindungen.Columns[3].HeaderText = "Verspätung";

            }

        }

        private string zeitFormatierer(string formatieren, string format)
        {
            DateTime datum;
            string resultat = "";
            DateTime.TryParse(formatieren, out datum);
            resultat = datum.ToString(format);
            return resultat;
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

        private void btnAbfahrtstafel_Click(object sender, EventArgs e)
        {
            Transport trans = new Transport();
            List<Station> stationen = trans.GetStations(comAbfahrt.Text.Split(',')[0]).StationList;
            string id = "";
            foreach (var station in stationen)
            {
                if (station.Name == comAbfahrt.Text)
                {
                    id = station.Id;
                }
            }

            StationBoardRoot board = trans.GetStationBoard(comAbfahrt.Text, id);
            List<StationBoard> abfahrtstafel = board.Entries;

            dgvVerbindungen.DataSource = abfahrtstafel;
            dgvVerbindungen.Columns["To"].HeaderText = "Zielstation";
            dgvVerbindungen.Columns["Number"].HeaderText = "Nummer";
            dgvVerbindungen.Columns["Operator"].HeaderText = "Anbieter";


        }

        private void btnStationAbfahrtSuchen_Click_1(object sender, EventArgs e)
        {
            string station = comAbfahrt.Text;
            browserOeffner(station);
        }

        private void btnStationAnkunftSuchen_Click(object sender, EventArgs e)
        {

            string station = comAnkunft.Text;
            browserOeffner(station);
        }

        private void browserOeffner(string station)
        {
            StringBuilder URL = new StringBuilder();
            URL.Append("https://www.google.ch/maps/place");

            if (station != string.Empty)
            {
                URL.Append("/" + station);
            }
            System.Diagnostics.Process.Start(URL.ToString());
        }

        private void btnOrten_Click(object sender, EventArgs e)
        {


            /*    public Form1()
                {
                    InitializeComponent();

                    _geoWatcher = new GeoCoordinateWatcher();

                    _geoWatcher.StatusChanged += GeoWatcherOnStatusChanged;
                }


    private GeoCoordinateWatcher _geoWatcher;

          /*  private void fetchGeo_Click(object sender, EventArgs e)
            {
                _geoWatcher.Start();

                fetchGeo.Enabled = false;
            }

            private void GeoWatcherOnStatusChanged(object sender, GeoPositionStatusChangedEventArgs e)
           {
                if (e.Status != GeoPositionStatus.Ready) return;

                GeoPositionPermission allowed = _geoWatcher.Permission;


                GeoPosition<GeoCoordinate> coordinate = _geoWatcher.Position;

                GeoCoordinate deviceLocation = coordinate.Location;
                DateTimeOffset fetchedAt = coordinate.Timestamp;
                reply.Text = string.Format("Lat: {0}, Long: {1}, fetched at: {2}",
                    deviceLocation.Latitude,
                    deviceLocation.Longitude,
                    fetchedAt.DateTime.ToShortTimeString());
            }*/

        }


    }
}



