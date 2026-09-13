using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDay07.Problem10
{
    internal class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        // Override the virtual method
        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }

        // Implement the abstract method
        public override double CalculateArea()
        {
            return Width * Height;
        }
    }
}
