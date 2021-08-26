using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garage2._0G6.Models.ViewModels
{
    public class ListViewModel
    {
        public IEnumerable<VehiclesListViewModel> VehicleList { get; set; }

        public int CarCount { get; set; }
        public int BusCount { get; set; }
        public int BoatCount { get; set; }
        public int MotorcycleCount { get; set; }
        public int AirplaneCount { get; set; }

        public int VehicleCount { get; set; }
        public int WheelCount { get; set; }
        public double Revenue { get; set; }
    }
}
