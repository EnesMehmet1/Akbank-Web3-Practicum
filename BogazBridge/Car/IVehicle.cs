using BogazBridge.login;
using BogazBridge.manager;
using System;
using System.Collections.Generic;
using System.Text;

namespace BogazBridge.Car
{
    public interface IVehicle
    {
        public int Add(Login l,Manager M);
        public int Vehiclecoefficient { get; set; }
    }
}
