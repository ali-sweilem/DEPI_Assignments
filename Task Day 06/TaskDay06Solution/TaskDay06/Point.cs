using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDay06
{
    internal class Point
    {
        private int X;
        private int Y;

        // Default Ctor
        public Point()
        {
            X = 0;
            Y = 0;
        }

        // Parameterized Ctor
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Override ToString()
        public override string ToString()
        {
            return $"({X}, {Y})";
        }

    }
}
