using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentAdmin.models
{
    internal class User
    {
        public int Id { get; set; }
        public String name { get; set; }
        public String username { get; set; }
        public String password { get; set; }
        public int level { get; set; }
    }

}
