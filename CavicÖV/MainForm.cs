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
using System.Net.Mail;

namespace CavicÖV
{
    public partial class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();
            /*Event abonnieren(textChanged)*/
            this.autoSucheAbfahrt.getTextBox().TextChanged += userControl_TextChanged;
            this.autoSucheAnkunft.getTextBox().TextChanged += userControl_TextChanged;

            this.ActiveControl = autoSucheAbfahrt.getTextBox();
            /*
             Konnte nicht verwendet werden, da im UserControl auch Enter-Taste verwendet wird.
            this.AcceptButton = btnSuchen;*/

            this.autoSucheAbfahrt.onEnterPressed += AutoSucheAbfahrt_onEnterPressed;
            this.autoSucheAnkunft.onEnterPressed += AutoSucheAbfahrt_onEnterPressed;
        }

        private void AutoSucheAbfahrt_onEnterPressed(object sender, EventArgs e)
        {
            this.AcceptButton = btnSuchen;
        }

        private void userControl_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = null;

            /*Button Suchen einblenden*/
            if (this.autoSucheAbfahrt.getTextBox().Text != "" && this.autoSucheAnkunft.getTextBox().Text != "")
            {
                this.btnSuchen.Enabled = true;

            }
            else
            {
                this.btnSuchen.Enabled = false;
            }
            /*Abfahrtstafel und Orten einblenden*/
            if (autoSucheAbfahrt.getTextBox().Text != "")
            {
                this.btnAbfahrtstafel.Enabled = true;
                this.btnStationAbfahrtSuchen.Enabled = true;
            }
            else
            {
                this.btnStationAbfahrtSuchen.Enabled = false;
                this.btnAbfahrtstafel.Enabled = false;
            }
            /*Abfahrtstafel nur einblenden, wenn Abfahrtsort eingegeben ist.*/
            if (autoSucheAbfahrt.getTextBox().Text != "" && autoSucheAnkunft.getTextBox().Text != "")
            {
                this.btnAbfahrtstafel.Enabled = false;
            }
            if (autoSucheAnkunft.getTextBox().Text != "")
            {
                this.btnStationAnkunftSuchen.Enabled = true;
            }
            else
            {
                this.btnStationAnkunftSuchen.Enabled = false;
            }

        }

        private void btnSuch_Click(object sender, EventArgs e)
        {
            Transport verbindung = new Transport();

            /*Verbindungen auslesen*/
            Connections strecke = verbindung.GetConnections(autoSucheAbfahrt.text, autoSucheAnkunft.text, zeitFormatierer(dateTimePickerAll.Text, "yyyy-MM-dd HH:mm"));

            List<MeineVerbindungen> meineVerbindungen = new List<MeineVerbindungen>();

            /*Von jedem gefundenen Element werden die Daten in mv gespeichert und danach einer List hinzufügt. Die Liste wird danach dem DataGridView übergeben.*/
            foreach (Connection c in strecke.ConnectionList)
            {
                MeineVerbindungen mv = new MeineVerbindungen(c.Duration, c.From.Departure, c.To.Arrival, c.From.Delay);

                mv.arrival = zeitFormatierer(mv.arrival, "HH:mm");
                mv.departure = zeitFormatierer(mv.departure, "HH:mm");
                mv.duration = mv.duration.Substring(3, 5);
                meineVerbindungen.Add(mv);

            }
            /*DataGridView Daten einfügen*/
            dgvVerbindungen.DataSource = meineVerbindungen;

            /*Headertext anpassen*/
            dgvVerbindungen.Columns[0].HeaderText = "Dauer";
            dgvVerbindungen.Columns[1].HeaderText = "Abfahrtszeit";
            dgvVerbindungen.Columns[2].HeaderText = "Ankunftszeit";
            dgvVerbindungen.Columns[3].HeaderText = "Verspätung";

        }

        private void btnAbfahrtstafel_Click(object sender, EventArgs e)
        {
            Transport trans = new Transport();

            List<Station> stationen = trans.GetStations(autoSucheAbfahrt.text.Split(',')[0]).StationList;
            string id = "";

            /*Abfahtsstation ID herauslesen*/
            foreach (var station in stationen)
            {
                if (station.Name == autoSucheAbfahrt.text)
                {
                    id = station.Id;
                }
            }

            /*Abfahrtstafel herauslesen*/
            StationBoardRoot board = trans.GetStationBoard(autoSucheAbfahrt.text, id);
            List<StationBoard> abfahrtstafel = board.Entries;

            /*Selektrieren, was man in DataGridView augeben will*/
            var newList = abfahrtstafel.Select(l => new
            {
                l.Number,
                l.To,
                l.Operator,
                l.Category

            }).ToList();

            /*DataGridView Daten einfügen*/
            dgvVerbindungen.DataSource = newList;

            /*Headertext anpassen*/
            dgvVerbindungen.Columns["To"].HeaderText = "Zielstation";
            dgvVerbindungen.Columns["Number"].HeaderText = "Nummer";
            dgvVerbindungen.Columns["Operator"].HeaderText = "Anbieter";
            dgvVerbindungen.Columns["Category"].HeaderText = "Kategorie";

        }

        private void btnStationAbfahrtSuchen_Click_1(object sender, EventArgs e)
        {
            string station = autoSucheAbfahrt.text;
            browserOeffner(station);
        }

        private void btnStationAnkunftSuchen_Click(object sender, EventArgs e)
        {
            string station = autoSucheAnkunft.text;
            browserOeffner(station);
        }

        private void btnOrten_Click(object sender, EventArgs e)
        {
            GeoCoordinateWatcher GEOWatcher = new GeoCoordinateWatcher();

            /*Koordinaten auslesen*/
            GeoCoordinate Coordinates = GEOWatcher.Position.Location;

            Transport trans = new Transport();
            /*Koordinaten übergeben und danach im Usercontrol ausgeben.*/
            var a = trans.getStationWithXY(Coordinates.Latitude, Coordinates.Longitude).StationList;
            var ab = a.First();
            autoSucheAbfahrt.getTextBox().Text = Convert.ToString(ab);

        }

        /* 
         * Versuch Verbindung mit Mail zu versenden, gin nicht kam immer Fehler:"Es ist ein Fehler aufgetreten."
         * Buttons und TextBoxen sind noch vorhanden, aber wurden von mir ausgeblendet.
         * 
         * private void button1_Click(object sender, EventArgs e)
         {


             try
             {
                 MailMessage mail = new MailMessage();
                 SmtpClient SmtpServer = new SmtpClient("smtp.lice.com");
                 SmtpServer.Port = 25;
                 mail.From = new MailAddress(textBox1.Text);
                 mail.To.Add(textBox2.Text);
                 mail.Subject = "Fahrdaten";
                 mail.Body = "Report" + dgvVerbindungen.ToString();
                 SmtpServer.EnableSsl = false;

                 SmtpServer.Port = 587;
                 SmtpServer.Credentials = new System.Net.NetworkCredential(textBox1.Text, textBox2.Text);
                 SmtpServer.EnableSsl = true;

                 SmtpServer.Send(mail);
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message.ToString());
             }

         }*/
        private string zeitFormatierer(string formatieren, string format)
        {
            DateTime datum;
            string resultat = "";
            /*Formatiert string in DateTime*/
            DateTime.TryParse(formatieren, out datum);

            /*Formatiert string in gewünschtes Datum und Zeitformat*/
            resultat = datum.ToString(format);
            return resultat;
        }

        private void browserOeffner(string station)
        {
            StringBuilder URL = new StringBuilder();
            URL.Append("https://www.google.ch/maps/place");

            if (station != string.Empty)
            {
                /*URL Station hinzufügen.*/
                URL.Append("/" + station);
            }
            /*Standardbrowser auf dem PC öffnen mit gewünschten URL.*/
            System.Diagnostics.Process.Start(URL.ToString());
        }


    }
}



