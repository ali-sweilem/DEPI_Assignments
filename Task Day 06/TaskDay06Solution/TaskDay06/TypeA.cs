using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDay06
{
    internal class TypeA
    {
        private int F;
        internal int G;
        public int H;

        // To access F we need get or set method
        public int f
        {
            get { return F; }
            set { F = value; }
        }
    }
}
