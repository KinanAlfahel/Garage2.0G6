using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Garage2._0G6.Models.ViewModels
{
    public class VehicleViewModel
    {
        public int Id { get; set; }
        //public VehicleType Type { get; set; }
        [DisplayName("Registration number")]
        public string Regnum { get; set; }

        //public string Color { get; set; } To make it Different.

        //public string Brand { get; set; }

        [DisplayName("Vehicle Model")]
        public string Model { get; set; }

        //public int Wheel { get; set; }

        [DisplayName("Arrival Time")]
        public DateTime Arrivaldate { get; set; }

        [DisplayName("Parked Time")]
        public TimeSpan ParkedTime { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd-hh-mm}", ApplyFormatInEditMode = true)]
        //[DisplayName("Arrival time")]
        private TimeSpan parkedTime;
    }
}
