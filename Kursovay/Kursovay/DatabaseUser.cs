using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovay
{
    class DatabaseUser : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Users.db");

        }


        public DbSet<Log> log { get; set; }
        public DbSet<Roles> roles { get; set; }
    }
}
