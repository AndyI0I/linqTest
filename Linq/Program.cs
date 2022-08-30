using Linq;
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


        public void DBTest()
        {
            using var db = new MitarbeiterContext();

            // Note: This sample requires the database to be created before running.
        

            // Create
            Console.WriteLine("Inserting a new Mitarbeiter");
            db.Add(new Mitarbeiter(123, "Max", "Muster", DateTime.Now));
            db.SaveChanges();

            // Read
            Console.WriteLine("Querying for a Mitarbeiter");
            var mitarbeiter = db.Mitarbeiter
                .OrderBy(b => b.PersonalNummer)
                .First();

            // Update
            Console.WriteLine("Updating the Mitarbeiter");
            mitarbeiter.Nachname = "Felder";
            db.SaveChanges();

            // Delete
            Console.WriteLine("Delete the Mitarbeiter");
            db.Remove(mitarbeiter);
            db.SaveChanges();
        }


        public static void Main(string[] vs)
        {
            MainApp mainApp = new();
            //mainApp.run();
            mainApp.DBTest();
        }
    }
}