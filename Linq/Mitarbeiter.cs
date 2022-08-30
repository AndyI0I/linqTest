namespace Programm
{
    public class Mitarbeiter
    {
        private int personalNummer;
        private string vorname;
        private string nachname;
        private DateTime eintrittsdatum;

        public Mitarbeiter(int personalNummer, string vorname, string nachname, DateTime eintrittsdatum)
        {
            this.personalNummer = personalNummer;
            this.vorname = vorname;
            this.nachname = nachname;
            this.eintrittsdatum = eintrittsdatum;
        }

        public int PersonalNummer { get => personalNummer; set => personalNummer = value; }
        public string Vorname { get => vorname; set => vorname = value; }
        public string Nachname { get => nachname; set => nachname = value; }
        public DateTime Eintrittsdatum { get => eintrittsdatum; set => eintrittsdatum = value; }
    }
}