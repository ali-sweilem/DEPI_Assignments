using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDay07.Problem6
{
    internal class Circle : IShape
    {
        public double Radius { get; set; }

        public double Area 
        {
            get { return Math.PI * Radius * Radius; } 
        }

        public void Draw()
        {
            Console.WriteLine("Drawing a Circle");
        }

    }
}
