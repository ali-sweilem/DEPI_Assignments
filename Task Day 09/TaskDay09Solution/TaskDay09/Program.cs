using System;
using TaskDay09.Problem3;
using TaskDay09.Problem4;
using TaskDay09.Problem5;
using TaskDay09.Problem8;
using TaskDay09.Problem9;

namespace TaskDay09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem1
            //foreach (Weekdays day in Enum.GetValues(typeof(Weekdays)))  // Old style
            //{
            //    Console.WriteLine($"{day} = {(int)day}");
            //}
            #endregion

            #region Problem2
            //foreach (Grades grade in Enum.GetValues<Grades>())  // Style Generic
            //{
            //    Console.WriteLine($"{grade} = {(short)grade}");
            //}
            #endregion

            #region Problem3
            //Person p1 = new Person();
            //Person p2 = new Person("CS");

            //Console.WriteLine(p1);
            //Console.WriteLine(p2);
            #endregion

            #region Problem4
            //Child child = new Child();

            //child.Salary = 5000;

            //child.DisplaySalary();
            #endregion

            #region Problem5
            //double perimeter = Utility.CalcPerimeter(10, 5);

            //Console.WriteLine($"Perimeter = {perimeter}");
            #endregion

            #region Problem6
            //ComplexNumber number1 = new ComplexNumber(2, 3);
            //ComplexNumber number2 = new ComplexNumber(4, 5);

            //ComplexNumber result = number1 * number2;

            //Console.Write("Result = ");
            //result.Display();
            #endregion

            #region Problem7
            //Console.WriteLine($"Size of int: {sizeof(int)} byte");
            //Console.WriteLine($"Size of byte: {sizeof(byte)} byte");
            #endregion

            #region Problem8
            //double celsius = 25;

            //double fahrenheit = Utility2.CelsiusToFahrenheit(celsius);

            //Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
            #endregion

            #region Problem9
            //Employee[] employees =
            //{
            //    new Employee(1, "Ali"),
            //    new Employee(2, "Ahmed"),
            //    new Employee(3, "Omar")
            //};

            //// Different object, but same Id as Ahmed
            //Employee employeeToSearch = new Employee(2, "Ahmed");

            //int index = Helper2<Employee>.SearchArray(
            //    employees,
            //    employeeToSearch
            //);

            //Console.WriteLine($"Employee found at index: {index}");
            #endregion


        }

        public enum Weekdays
        {
            Monday = 1,
            Tuesday, 
            Wednesday,
            Thursday, 
            Friday
        }

        public enum Grades : short
        {
            A = 4,
            B = 3,
            C = 2,
            D = 1,
            F = -1
        }

        enum GenderDefault
        {
            Male,
            Female
        }
        public enum Gender : byte
        {
            Male,
            Female
        }


    }
}
