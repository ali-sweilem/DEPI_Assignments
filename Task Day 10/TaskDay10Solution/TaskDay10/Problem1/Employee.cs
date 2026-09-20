using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDay10.Problem1
{
    internal class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Employee(int id, string name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public int CompareTo(Employee other)
        {
            return Id.CompareTo(other.Id);
        }

        public override string ToString()
        {
            return $"Id = {Id}, Name = {Name}, Salary = {Salary}";
        }
    }
}
