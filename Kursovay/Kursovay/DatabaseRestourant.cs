using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Kursovay
{
    class DatabaseRestourant : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Restourant.db");

        }


        public DbSet<Restourant> restourant { get; set; }
        public DbSet<Staff> staff { get; set; }
        public DbSet<Products> products { get; set; }
        public DbSet<Delivery> delivery { get; set; }
    }
}
