using Garage2._0G6.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garage2._0G6.Models
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly Garage2_0G6Context _context;

        public VehicleRepository(Garage2_0G6Context context)
        {
            _context = context;
        }
        public IEnumerable<Vehicle> AllVehicles 
        {
            get
            {
                return _context.Vehicle;
            }
        }

        public Vehicle GetVehicleById(int id)
        {
            return _context.Vehicle.FirstOrDefault(v => v.Id == id);
        }

        public int GetVehicleCount()
        {
            int result = _context.Vehicle.Count();

            return result;
        }

        public int GetWheelCount()
        {
            int result = 0;

            foreach (var vehicle in _context.Vehicle)
            {
                result += vehicle.Wheel;
            }

            return result;
        }

        public double GetRevenue()
        {
            double revenue = 0;

            foreach (var vehicle in _context.Vehicle)
            {
                revenue += ((short)(DateTime.Now - vehicle.Arrivaldate).TotalMinutes) * 1;
            }

            return revenue;
        }

        public int GetVehicleAmount(VehicleType type)
        {
            int amount = 0;

            foreach (var vehicle in _context.Vehicle)
            {
                if (vehicle.Type == type)
                {
                    amount++;
                }
            }

            return amount;
        }
    }
}
