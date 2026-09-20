using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDay09.Problem4
{
    internal class Child : Parent
    {
        public sealed override decimal Salary
        {
            get { return base.Salary; }
            set { base.Salary = value; }
        }

        public void DisplaySalary()
        {
            Console.WriteLine($"Salary: {Salary}");
        }
    }
}
