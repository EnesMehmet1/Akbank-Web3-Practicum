using BogazBridge.Counter;
using System;
using System.Collections.Generic;
using System.Text;

namespace BogazBridge.manager
{
    public class Manager
    {
        public int TotalMoney { get; set; }
        public void Rapor(counter c)
        {
            c.print();
            Console.WriteLine("Günlük Bakiye:");
            Console.WriteLine(TotalMoney);
        }
    }
}
