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
                   new Vehicle { Id = 1, Type = VehicleType.Car, Regnum = "123ABC", Color = "red", Brand = "Volvo", Model = "X3", Wheel = 4, Arrivaldate = DateTime.Now },
                   new Vehicle { Id = 2, Type = VehicleType.Car, Regnum = "125ABC", Color = "red", Brand = "Toyota", Model = "Corolla", Wheel = 4, Arrivaldate = DateTime.Now },
                   new Vehicle { Id = 3, Type = VehicleType.Car, Regnum = "226ABC", Color = "blue", Brand = "Volvo", Model = "XC60", Wheel = 4, Arrivaldate = DateTime.Now },
                   new Vehicle { Id = 4, Type = VehicleType.Car, Regnum = "122ABC", Color = "black", Brand = "Volvo", Model = "X3", Wheel = 4, Arrivaldate = DateTime.Now },
                   new Vehicle { Id = 5, Type = VehicleType.Motorcycle, Regnum = "225ABC", Color = "black", Brand = "Harley Davidson", Model = "Street 750", Wheel = 2, Arrivaldate = DateTime.Now },
                   new Vehicle { Id = 6, Type = VehicleType.Motorcycle, Regnum = "115ABC", Color = "red", Brand = "Yamaha", Model = "Bolt", Wheel = 2, Arrivaldate = DateTime.Now },
                   new Vehicle { Id = 7, Type = VehicleType.Boat, Regnum = "112ABC", Color = "white", Brand = "Volvo", Model = "Epic V8", Wheel = 0, Arrivaldate = DateTime.Now },
                   new Vehicle { Id = 8, Type = VehicleType.Boat, Regnum = "321ABC", Color = "red", Brand = "Toyota", Model = "Epic SX", Wheel = 0, Arrivaldate = DateTime.Now },
                   new Vehicle { Id = 9, Type = VehicleType.Bus, Regnum = "322ABC", Color = "blue", Brand = "Volvo", Model = "X4", Wheel = 6, Arrivaldate = DateTime.Now },
                   new Vehicle { Id = 10, Type = VehicleType.Airplane, Regnum = "331ABC", Color = "white", Brand = "Yamaha", Model = "Revell", Wheel = 6, Arrivaldate = DateTime.Now }

               );
        }
    }
}
