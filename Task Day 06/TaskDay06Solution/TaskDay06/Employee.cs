using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDay06
{
    internal struct Employee
    {
        private int empId;
        private string Name;
        private decimal salary;

        // GetName method
        public string GetName()
        {
            return Name;
        }

        // SetName method
        public void SetName(string name)
        {
            Name = name;
        }

        // Properties
        public int EmpId
        {
            get { return empId; }
            set { empId = value; }
        }


        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

    }
}
