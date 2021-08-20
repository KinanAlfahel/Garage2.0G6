using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Garage2._0G6.Models
{
    public class VehicleCreateModel
    {
        public int Id { get; set; }

        [DisplayName("Vehicle Type")]
        public VehicleType Type { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"), StringLength(50)]
        // check with datbase for index
        [DisplayName("Registration Number")]
        public string Regnum { get; set; }

        [DisplayName("Vehicle Color")]
        public string Color { get; set; }

        [DisplayName("Vehicle Brand")]
        public string Brand { get; set; }

        [DisplayName("Vehicle Model")]
        public string Model { get; set; }

        [Range(1, Int32.MaxValue, ErrorMessage = "Value should be greater than or equal to 1")]
        [DisplayName("Number of Wheels")]
        public int Wheel { get; set; }

    }

}
