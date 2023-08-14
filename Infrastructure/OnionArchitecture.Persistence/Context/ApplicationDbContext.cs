using Microsoft.EntityFrameworkCore;
using OnionArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Persistence.Context
{
    public sealed class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>().HasData(
                new Vehicle { Id = 1, Name = "Plane", Price = 1000, Year = 1998 },
                new Vehicle { Id = 2, Name = "Car", Price = 2000, Year = 2001 },
                new Vehicle { Id = 3, Name = "Ship", Price = 3000, Year = 2002 },
                new Vehicle { Id = 4, Name = "Bus", Price = 4000, Year = 2019 }
                );
        }
    }
}
