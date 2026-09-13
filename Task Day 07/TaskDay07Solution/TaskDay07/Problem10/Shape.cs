using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDay07.Problem10
{
    internal abstract class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing Shape");
        }
        public abstract double CalculateArea();
    }
}
