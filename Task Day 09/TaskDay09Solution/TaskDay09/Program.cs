using System;
using TaskDay09.Problem3;

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

            Person p1 = new Person();
            Person p2 = new Person("CS");

            Console.WriteLine(p1);
            Console.WriteLine(p2);

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


    }
}
