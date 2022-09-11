using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using BogazBridge.Car;
using BogazBridge.login;
using BogazBridge.manager;

namespace BogazBridge.Counter
{
    public class counter
    {
       public  ArrayList Vehicles = new ArrayList();
        public void OKEF(IVehicle vehicle,Login l,Manager M)
        {
            vehicle.Add(l,M);
            GOGA(l);
        }
        public void GOGA(Login l)
        {
            Vehicles.Add(l.HGSNO); //hgs numbers of vehicles
        }

        public void print()
        {
            Console.WriteLine("Giriş Yapan araçlar:");
            foreach(var x in Vehicles)
            {
                Console.WriteLine(x);
            }
        }
    }
}
