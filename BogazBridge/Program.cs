using BogazBridge.Car;
using BogazBridge.Counter;
using BogazBridge.login;
using BogazBridge.manager;
using System;
using System.Collections.Generic;

namespace BogazBridge
{
    class Program
    {
        static void Main(string[] args)
        {
            counter c = new counter();

            Console.WriteLine("Araç Girişi");
            Console.WriteLine("Örnek prototipte 2 adet araç girişi mevcuttur");
            Console.WriteLine("Ardından raporlama kısmı vardır");

            Console.WriteLine("İsim,Soyisim,HGSNO,Araç Sınıfını sırası ile giriniz (2 kez tekrar edin)");
            List<Login> customers = new List<Login>
            {
            new Login //PRimary Vehicle
            {
                Name = Console.ReadLine(),
                LastName = Console.ReadLine(),
                HGSNO = Convert.ToInt32(Console.ReadLine()),
                VehicleClass = Convert.ToInt32(Console.ReadLine()),
                Time = DateTime.Now.Date,
                money = 1000
        },
            new Login //Secondly Vehicle
            {
                Name = Console.ReadLine(),
                LastName = Console.ReadLine(),
                HGSNO = Convert.ToInt32(Console.ReadLine()),
                VehicleClass = Convert.ToInt32(Console.ReadLine()),
                Time = DateTime.Now.Date,
                money = 1000
        }
            };

            Manager man = new Manager();
            foreach (var x in customers) { 
            switch (x.VehicleClass)
            {
                case 1:
                    c.OKEF(new Bus(),x,man);
                    break;
                case 2:
                    c.OKEF(new car(), x,man);
                    break;
                case 3:
                    c.OKEF(new MiniBus(),x,man);
                    break;
            }
            }
            man.Rapor(c);
            Console.ReadKey();
        }
    }
}
