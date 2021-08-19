using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garage2._0G6.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public VehicleType Type { get; set; }
        public string Regnum { get; set; }

        public string Color { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int Wheel { get; set; }

        public DateTime Arrivaldate { get; set; }
    }

    public enum VehicleType
    {
        Airplane,
        Boat,
        Bus,
        Car,
        Motorcycle
    }
}
