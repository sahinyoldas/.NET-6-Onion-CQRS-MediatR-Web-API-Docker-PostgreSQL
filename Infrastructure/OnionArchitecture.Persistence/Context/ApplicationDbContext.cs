using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OnionArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Persistence.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Vehicle> Vehicles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("User ID=postgres;Password=postgres;Server=localhost;Port=5433;Database=WebAPICrudDB;IntegratedSecurity=true;Pooling=true;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>().HasData(
                new Vehicle { Id = 1, Name = "Plane", Price = 1000, Year = 1998 },
                new Vehicle { Id = 2, Name = "Car", Price = 2000, Year = 2001 },
                new Vehicle { Id = 3, Name = "Ship", Price = 3000, Year = 2002 },
                new Vehicle { Id = 4, Name = "Bus", Price = 4000, Year = 2019 }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
