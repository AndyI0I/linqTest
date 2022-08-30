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

        public string DbPath { get; }

        public MitarbeiterContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "Mitarbeiter.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer($"Data Source={DbPath}");
    }
}
