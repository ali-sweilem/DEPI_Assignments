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

            #region Problem3
            //int? num = null;

            //// The null-coalescing operator
            //int result = num ?? 10;

            //// Check if the nullable integer has a value
            //if (num.HasValue)
            //{
            //    Console.WriteLine($"Value: {num.Value}");
            //}
            //else
            //{
            //    Console.WriteLine("The number is null.");
            //}

            //// Assign a value to the nullable integer
            //num = 20;

            //if (num.HasValue)
            //{
            //    Console.WriteLine($"HasValue: {num.HasValue}");
            //    Console.WriteLine($"Value: {num.Value}");
            //}
            #endregion

            #region Problem4
            //int[] arr = new int[5];

            //try
            //{

            //    Console.WriteLine(arr[5]);
            //}
            //catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine("Error: Index is out of range.");
            //}
            #endregion

            #region Problem5
            //int[,] arr = 
            //{
            //    { 1, 2, 3 },
            //    { 4, 5, 6 },
            //    { 7, 8, 9 }
            //};

            //// Sum of each row
            //for (int rows = 0; rows < arr.GetLength(0); rows++)
            //{
            //    Console.WriteLine($"Row {rows + 1}");
            //    int Rsum = 0;
            //    for (int columns = 0; columns < arr.GetLength(1); columns++)
            //    {
            //        Rsum += arr[rows, columns];
            //    }
            //    Console.WriteLine($" The sum of row {rows + 1} is: {Rsum}");
            //}

            //// Sum of each column
            //for (int columns = 0; columns < arr.GetLength(1); columns++)
            //{
            //    Console.WriteLine($"Column {columns + 1}");
            //    int Csum = 0;
            //    for (int rows = 0; rows < arr.GetLength(0); rows++)
            //    {
            //        Csum += arr[rows, columns];
            //    }
            //    Console.WriteLine($" The sum of column {columns + 1} is: {Csum}");
            //}
            #endregion

            #region Problem6
            //// Create a jagged array with three rows of different sizes
            //int[][] numbers = new int[3][];

            //numbers[0] = new int[2];
            //numbers[1] = new int[3];
            //numbers[2] = new int[4];

            //// Populate each row with user input
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    for (int j = 0; j < numbers[i].Length; j++)
            //    {
            //        Console.Write($"Enter value for Row {i + 1}, Index {j}: ");
            //        numbers[i][j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //// Print all values row by row
            //Console.WriteLine("\nArray values:");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"Row {i + 1}: ");

            //    for (int j = 0; j < numbers[i].Length; j++)
            //    {
            //        Console.Write(numbers[i][j] + " ");
            //    }

            //    Console.WriteLine();
            //}
            #endregion


            string? name = null;

            Console.Write("Do you want to enter your name? (yes/no): ");
            string? answer = Console.ReadLine();

            // Assign a value conditionally
            if (answer == "yes")
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
            }

            // Use the null-forgiveness operator
            string? noname = name ?? "Anonymous";
            Console.WriteLine($"Hello, {noname!}");
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

