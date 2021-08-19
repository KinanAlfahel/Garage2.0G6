using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Garage2._0G6.Models;

namespace Garage2._0G6.Data
{
    public class Garage2_0G6Context : DbContext
    {
        public Garage2_0G6Context (DbContextOptions<Garage2_0G6Context> options)
            : base(options)
        {
        }

        public DbSet<Garage2._0G6.Models.Vehicle> Vehicle { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Vehicle>()
               .HasData(
                   new Vehicle { Id = 1, Type = "A", Regnum = "123ABC", Color = "red", Brand = "Volvo", Model = "X3", Wheel = 4, Arrivaldate = DateTime.Now },
                   new Vehicle { Id = 2, Type = "A", Regnum = "125ABC", Color = "red", Brand = "Volvo", Model = "X3", Wheel = 4, Arrivaldate = DateTime.Now }

               );
        }
    }
}
