using System;


namespace Programm
{
    public class MainApp
    {


        public void run()
        {
            List<Mitarbeiter> mitarbeiters = new List<Mitarbeiter>();
            mitarbeiters.Add(new Mitarbeiter(123, "Andreas", "Felder", DateTime.Now));
            mitarbeiters.Add(new Mitarbeiter(124, "Max", "Muster", DateTime.Now));
            mitarbeiters.Add(new Mitarbeiter(124, "John", "Doe", DateTime.Now));

            var MitQuery =
                from mit in mitarbeiters
                where mit.Vorname.Trim().StartsWith("J")
                select mit;

            foreach (Mitarbeiter mit in MitQuery)
            {
                Console.WriteLine("Mitarbeiter");
                Console.WriteLine("\tPersonalnummer: " + mit.PersonalNummer);
                Console.WriteLine("\tVorname: " + mit.Vorname);
                Console.WriteLine("\tNachname: " + mit.Nachname);
                Console.WriteLine("\tEintrittsdatum: " + mit.Eintrittsdatum);
            }

            Console.WriteLine();

            var MitQuery2 = mitarbeiters.Where(mit => mit.Vorname.StartsWith("J"));


            foreach (Mitarbeiter mit in MitQuery2)
            {
                Console.WriteLine("Mitarbeiter");
                Console.WriteLine("\tPersonalnummer: " + mit.PersonalNummer);
                Console.WriteLine("\tVorname: " + mit.Vorname);
                Console.WriteLine("\tNachname: " + mit.Nachname);
                Console.WriteLine("\tEintrittsdatum: " + mit.Eintrittsdatum);
            }
        }



        public static void Main(string[] vs)
        {
            MainApp mainApp = new();

            mainApp.run();
        }
    }
}