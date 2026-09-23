using System;

namespace TaskDay11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            // --------------- Problem 1 -----------------//
            //var t1 = 2004;
            //var t2 = "Ali";
            //var t3 = "175.5";
            //var t4 = true;
            //var t5 = new int[] { 1,2,3 };

            //Console.WriteLine(t1.GetType());
            //Console.WriteLine(t2.GetType());
            //Console.WriteLine(t3.GetType());
            //Console.WriteLine(t4.GetType());
            //Console.WriteLine(t5.GetType());

            // --------------- Problem 2 -----------------//
            // Explicit types

            //int age = 22;
            //string name = "Ali";
            //double salary = 15000.5;
            //bool isActive = true;


            // Using var

            //var age2 = 22;
            //var name2 = "Ali";
            //var salary2 = 15000.5;
            //var isActive2 = true;

            /*
               The result is exactly the same at compile time because the compiler
               infers the type of each variable when var is used.
               For example, var age2 = 22; is compiled as int age2 = 22;
            */
            #endregion

            #region Part02
            var anonymous = new {Name = "CocaCola", Price = 15.0, Quantity = 22};
            Console.WriteLine(anonymous.ToString());

            var AnonymousArray = new[] 
            {
                new { Name = "Ali", Grade = 90 },
                new { Name = "Ahmed", Grade = 85 },
                new { Name = "Omar", Grade = 95 }
            };

            foreach (var item in AnonymousArray)
            {
                Console.WriteLine(item.ToString());
            }
            #endregion
        }
    }
}
