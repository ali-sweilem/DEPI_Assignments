using System;

namespace TaskDay05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Problem1
            //try
            //{
            //    Console.WriteLine("Enter the first number:");
            //    bool n1 = int.TryParse(Console.ReadLine(), out int num1);

            //    Console.WriteLine("Enter the second number:");
            //    bool n2 = int.TryParse(Console.ReadLine(), out int num2);

            //    int divide = num1 / num2;
            //}
            //catch
            //{
            //    Console.WriteLine("Error: Cannot divide by zero.");
            //}
            //finally
            //{
            //    Console.WriteLine("Operation complete");
            //}
            #endregion

            #region Problem2
            //try
            //{
            //    Console.Write("Enter X: ");
            //    int x = int.Parse(Console.ReadLine());

            //    Console.Write("Enter Y: ");
            //    int y = int.Parse(Console.ReadLine());

            //    TestDefensiveCode(x, y);
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion


            int? num = null;

            // The null-coalescing operator
            int result = num ?? 10;

            // Check if the nullable integer has a value
            if (num.HasValue)
            {
                Console.WriteLine($"Value: {num.Value}");
            }
            else
            {
                Console.WriteLine("The number is null.");
            }

            // Assign a value to the nullable integer
            num = 20;

            if (num.HasValue)
            {
                Console.WriteLine($"HasValue: {num.HasValue}");
                Console.WriteLine($"Value: {num.Value}");
            }

        }

        public static void TestDefensiveCode(int x, int y)
        {
            if (x < 0)
            {
                throw new ArgumentException("X must be a positive integer");
            }
            if (y <= 1)
            {
                throw new ArgumentException("Y must be greater than 1.");
            }

            Console.WriteLine($"X = {x}, Y = {y}");

        }

    }
}

