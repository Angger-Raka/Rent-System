using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentAdmin.models
{
    internal class transaksi
    {
        public int id;
        public int user_id;
        public int customer_id;
        public int car_id;
        public DateTime rent_date;
        public DateTime return_date;
        public float total_price;
    }
}
