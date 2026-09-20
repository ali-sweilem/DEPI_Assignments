using System;
using TaskDay10.Problem1;

namespace TaskDay10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] emp =
            {
                new Employee (3, "Ali", 500),
                new Employee (1, "Moo", 1500),
                new Employee (2, "Abdo", 350)
            };

            SortingAlgorithm<Employee>.Sort (emp);
            foreach (Employee item in emp)
            {
                Console.WriteLine(item);
            }
        }
    }
}
