using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDay07.Problem6
{
    internal interface IShape
    {
        public int Area { get; }

        void Draw();
    }
}
