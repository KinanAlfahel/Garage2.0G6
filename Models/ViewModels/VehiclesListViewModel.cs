using Garage2._0G6.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Garage2._0G6.Models.ViewModels
{
    public class VehiclesListViewModel
    {
        public int Id { get; set; }
        public VehicleType Type { get; set; }
        public string Regnum { get; set; }
        public DateTime Arrivaldate { get; set; }
    }
}
