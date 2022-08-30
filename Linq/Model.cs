using Microsoft.EntityFrameworkCore;
using Programm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class MitarbeiterContext: DbContext
    {
        public DbSet<Mitarbeiter> Mitarbeiter { get; set; } 

   

        public MitarbeiterContext()
        {
           
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\csharp\linqTest\Linq\Mitarbeiter.mdf;Integrated Security=True");
    }
}
