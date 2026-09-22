using System;
using System.Reflection;
using TaskDay10.Problem1;
using TaskDay10.Problem2;
using TaskDay10.Problem4;

namespace TaskDay10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem1
            //Employee[] emp =
            //{
            //    new Employee (3, "Ali", 500),
            //    new Employee (1, "Moo", 1500),
            //    new Employee (2, "Abdo", 350)
            //};

            //SortingAlgorithm<Employee>.Sort (emp);
            //foreach (Employee item in emp)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Problem2
            //static int Descending(int x, int y)
            //{
            //    return y.CompareTo(x);
            //}

            //int[] numbers = { 5, 2, 8, 1, 9, 3 };

            //SortingTwo<int>.Sort(numbers, Descending);

            //foreach (int number in numbers)
            //{
            //    Console.Write(number + " ");
            //}
            #endregion

            #region Problem3
            //static int CompareByLength(string x, string y)
            //{
            //    return x.Length.CompareTo(y.Length);
            //}

            //string[] names =
            //{
            //    "Ali",
            //    "Ahmed",
            //    "Amr",
            //    "Hossam",
            //    "Mohamed"
            //};

            //SortingTwo<string>.Sort(names, CompareByLength);

            //foreach (string name in names)
            //{
            //    Console.Write(name + " ");
            //}
            #endregion

            #region Problem4
            //Manager[] managers =
            //{
            //    new Manager(1, "Ali", 10000),
            //    new Manager(2, "Ahmed", 7000),
            //    new Manager(3, "Omar", 15000)
            //};

            //SortingTwo<Manager>.Sort(managers,(x, y) => x.CompareTo(y));

            //foreach (Manager manager in managers)
            //{
            //    Console.WriteLine($"{manager.Name} - {manager.Salary}");
            //}
            #endregion


        }
    }
}
