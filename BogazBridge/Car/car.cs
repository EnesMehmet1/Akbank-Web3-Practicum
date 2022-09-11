using BogazBridge.login;
using BogazBridge.manager;
using System;
using System.Collections.Generic;
using System.Text;

namespace BogazBridge.Car
{
    class car : IVehicle
    {
        public int Vehiclecoefficient { get; set; }
        public int Add(Login l, Manager M)
        {
            Vehiclecoefficient = 100;
            l.money = l.money - Vehiclecoefficient;
            M.TotalMoney += Vehiclecoefficient;
            return 0;
        }
        
    }
}
