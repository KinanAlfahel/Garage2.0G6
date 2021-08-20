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
    }
}
