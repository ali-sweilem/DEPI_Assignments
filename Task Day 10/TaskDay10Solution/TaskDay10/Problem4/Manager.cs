using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDay10.Problem4
{
    internal class Manager : Employee, IComparable<Manager>
    {
        public Manager(int id, string name, double salary) : base(id, name, salary)
        {
            
        }
        public int CompareTo(Manager mn)
        {
            return Salary.CompareTo(mn.Salary);
        }
    }
}
