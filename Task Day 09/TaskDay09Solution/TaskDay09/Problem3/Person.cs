using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDay09.Problem3
{
    internal class Person
    {
        public string Department { get; set; }

        public Person() : this("unknown")
        {
            
        }

        public Person(string dep)
        {
            Department = dep;
        }

        public override string ToString()
        {
            return $"The department is: {Department}";
        }
    }
}
