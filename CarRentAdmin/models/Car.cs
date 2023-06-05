using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentAdmin.models
{
    internal class Car
    {
        public int id { get; set; }

        public String brand { get; set; }

        public String plate { get; set; }

        public String color { get; set; }

        public DateTime year { get; set; }

        public int status { get; set; }

        public String car_seat_id { get; set; }

        public string pathimages { get; set; }
    }
}
