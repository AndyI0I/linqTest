using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Programm
{

  
    public class Mitarbeiter
    {
        [Key]
        public int PersonalNummer { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public DateTime Eintrittsdatum { get; set; }

        public Mitarbeiter(int personalNummer, string vorname, string nachname, DateTime eintrittsdatum)
        {
            this.PersonalNummer = personalNummer;
            this.Vorname = vorname;
            this.Nachname = nachname;
            this.Eintrittsdatum = eintrittsdatum;
        }

    }
}