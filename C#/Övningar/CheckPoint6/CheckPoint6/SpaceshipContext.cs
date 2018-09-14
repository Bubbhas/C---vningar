using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckPoint6
{
    public class SpaceshipContext : DbContext
    {
        public DbSet<Spaceship> Spaceships { get; set; }
        public DbSet<Food> Food { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
              "Server = (localdb)\\mssqllocaldb; Database = DbSpaceship;");
        }
    }
}
