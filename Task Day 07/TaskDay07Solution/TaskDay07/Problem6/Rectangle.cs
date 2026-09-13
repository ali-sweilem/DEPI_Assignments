using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDay07.Problem6
{
    internal class Rectangle : IShape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Area 
        {
            get { return Width * Height; } 
        }


        public void Draw()
        {
            Console.WriteLine("Drawing *_*");
        }
    }
}
