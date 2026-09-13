using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDay08.Problem1
{
    internal class Bike : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Bike: Start Engine");
        }

        public void StopEngine() 
        {
            Console.WriteLine("Bike: Stop Engine");
        }
    }
}
