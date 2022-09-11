using System;
using System.Collections.Generic;
using System.Text;

namespace BogazBridge.login
{
    public class Login:Person
    {
        public int HGSNO { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int VehicleClass { get; set; }
        public DateTime Time { get; set; }
        public int money { get; set; }
    }
}
