using System;

namespace TaskDay06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TypeA obj = new TypeA();

            Console.WriteLine(obj.G);
            Console.WriteLine(obj.H);
            Console.WriteLine(obj.f);

            Employee emp = new Employee();

            // Access using property
            emp.Salary = 10;
            emp.EmpId = 1;

            // Access Name using Method
            emp.SetName("Ali");

            Console.WriteLine("Employee Salary: " + emp.Salary);
            Console.WriteLine("Employee Name: " + emp.GetName());
            Console.WriteLine("Employee ID: " + emp.EmpId);
        }
    }
}
