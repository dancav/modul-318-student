namespace CavicÖV
{
    internal class MeineVerbindungen
    {
        public string duration { get; set; }
        public string departure { get; set; }
        public string arrival { get; set; }
        public int? delay { get; set; }
    
        public MeineVerbindungen(string duration, string departure, string arrival, int? delay)
        {
            this.duration = duration;
            this.departure = departure;
            this.arrival = arrival;
            this.delay = delay;

        }
    }
}