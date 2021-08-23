using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garage2._0G6.Models.ViewModels
{
    public class ReceiptViewModel
    {
        public int Id { get; set; }
        public string Regnum { get; set; }
        public string Model { get; set; }
        public DateTime Arrivaldate { get; set; }
        public DateTime Leavingdate { get; set; }
        public double Price { get; set; }

        public TimeSpan ParkingTime;


        //public int MyProperty { get; set; } Was just a dummy for re-commit


    }
}
