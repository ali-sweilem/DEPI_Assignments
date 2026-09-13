using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDay08.Problem5
{
    internal class Robot : IWalkable
    {
        public void Walk()
        {
            Console.WriteLine("Robot is walking normally.");
        }

        // Explicit interface implementation
        void IWalkable.Walk()
        {
            Console.WriteLine("Robot is walking using the IWalkable behavior.");
        }
    }
}
