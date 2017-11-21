namespace CavicÖV
{
    internal class MeineVerbindungen
    {
        /// <summary>
        /// Gibt die Dauer einer Verbindung zurück.
        /// </summary>
        public string duration { get; set; }

        /// <summary>
        /// Gibt die Abfahrtszeit einer Verbindung zurück.
        /// </summary>
        public string departure { get; set; }

        /// <summary>
        /// Gibt die Ankunftszeit einer Verbindung zurück.
        /// </summary> 
        public string arrival { get; set; }

        /// <summary>
        /// Gibt die Verspätung einer Verbindung zurück.
        /// </summary>
        public int? delay { get; set; }
    
        /// <summary>
        /// Setzt die Variablen innerhalb der Klasse mit Hilfe von Parameterübergabe.
        /// </summary>
        /// <param name="duration"></param>
        /// <param name="departure"></param>
        /// <param name="arrival"></param>
        /// <param name="delay"></param>
        public MeineVerbindungen(string duration, string departure, string arrival, int? delay)
        {
            this.duration = duration;
            this.departure = departure;
            this.arrival = arrival;
            this.delay = delay;

        }
    }
}