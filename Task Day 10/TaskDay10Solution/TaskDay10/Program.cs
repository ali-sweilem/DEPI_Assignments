using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
//using TaskDay10.Problem1;


//using TaskDay10.Problem1;
//using TaskDay10.Problem2;
using TaskDay10.Problem7;

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

            #region Problem5
            //Employee[] employee =
            //{
            //    new Employee(1, "Ali", 10000),
            //    new Employee(2, "Ahmed", 7000),
            //    new Employee(3, "Omar", 15000)
            //};

            //SortingTwo<Employee>.Sort(employee, CompareByNameLength);

            //static int CompareByNameLength(Employee emp1, Employee emp2)
            //{
            //    return emp1.Name.Length.CompareTo(emp2.Name.Length);
            //}

            //foreach (Employee emp in employee)
            //{
            //    Console.WriteLine(emp.Name);
            //}
            #endregion

            #region Problem6
            //int[] arr = { 3, 1, 5, 4, 2, 0 };
            //SortingTwo<int>.Sort(arr, (x, y) => x.CompareTo(y));
            //foreach (int i in arr)
            //{
            //    Console.Write($"{i}, ");
            //}
            #endregion

            #region Problem7
            //int[] arr = { 1, 2, 3, 4, 5 };
            //Console.WriteLine("Before swap");

            //foreach (int i in arr)
            //{
            //    Console.Write($"{i}, ");
            //}

            //SortingAlgorithm<int>.Swap(ref arr[0], ref arr[3]);
            //Console.WriteLine();
            //Console.WriteLine("After swap");
            //foreach (int i in arr)
            //{
            //    Console.Write($"{i}, ");
            //}
            #endregion

            #region Problem8

            #endregion
        }
    }
}
