using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garage2._0G6.Models
{
    public interface IVehicleRepository
    {
        IEnumerable<Vehicle> AllVehicles { get; }

        Vehicle GetVehicleById(int id);
    }
}
