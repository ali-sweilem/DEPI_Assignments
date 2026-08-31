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

            #region Problem7
            //string? name = null;

            //Console.Write("Do you want to enter your name? (yes/no): ");
            //string? answer = Console.ReadLine();

            //// Assign a value conditionally
            //if (answer == "yes")
            //{
            //    Console.Write("Enter your name: ");
            //    name = Console.ReadLine();
            //}

            //// Use the null-forgiveness operator
            //string? NoName = name ?? "Anonymous"; // for fun //
            //Console.WriteLine($"Hello, {NoName!}");
            #endregion

            #region Problem8
            //// Boxing: converting a value type to an object
            //int number = 100;
            //object obj = number;

            //Console.WriteLine($"Boxed value: {obj}");

            //try
            //{
            //    // Unboxing: converting the object back to int
            //    int result = (int)obj;

            //    Console.WriteLine($"Unboxed value: {result}");

            //    // Trying an invalid unboxing
            //    string text = (string)obj;
            //}
            //catch (InvalidCastException)
            //{
            //    Console.WriteLine("Error: Invalid cast. The object cannot be converted to the requested type.");
            //}
            #endregion

            #region Problem9
            //Console.Write("Enter the first integer: ");
            //int x = int.Parse(Console.ReadLine());

            //Console.Write("Enter the second integer: ");
            //int y = int.Parse(Console.ReadLine());

            //SumAndMultiply(x, y, out int sum, out int product);

            //Console.WriteLine($"Sum: {sum}");
            //Console.WriteLine($"Product: {product}");
            #endregion

            #region Problem10
            //// Using the default value (5)
            //PrintString("Hello");

            //Console.WriteLine();

            //// Using a named parameter
            //PrintString(text: "Welcome", times: 3);
            #endregion

            #region Problem11
            //int[]? numbers = null;

            //Console.WriteLine($"Array length: {numbers?.Length}");

            //numbers = new int[] { 10, 20, 30, 40, 50 };

            //Console.WriteLine($"Array length: {numbers?.Length}");
            #endregion

            #region Problem12
            //Console.Write("Enter a day of the week: ");
            //string day = Console.ReadLine();

            //int dayNumber = day.ToLower() switch
            //{
            //    "monday" => 1,
            //    "tuesday" => 2,
            //    "wednesday" => 3,
            //    "thursday" => 4,
            //    "friday" => 5,
            //    "saturday" => 6,
            //    "sunday" => 7,
            //    _ => 0
            //};

            //if (dayNumber == 0)
            //{
            //    Console.WriteLine("Invalid day.");
            //}
            //else
            //{
            //    Console.WriteLine($"Day number: {dayNumber}");
            //}
            #endregion

            #region Problem13
            //// Calling the method with individual values
            //int result1 = SumArray(10, 20, 30);

            //Console.WriteLine($"Sum of individual values: {result1}");

            //// Calling the method with an array
            //int[] numbers = { 5, 10, 15, 20 };

            //int result2 = SumArray(numbers);

            //Console.WriteLine($"Sum of array values: {result2}");
            #endregion


            //----------------------- Part 02 -----------------------//

            #region P1
            //Console.Write("Enter a positive integer: ");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= number; i++)
            //{
            //    Console.Write(i);

            //    if (i < number)
            //    {
            //        Console.Write(", ");
            //    }
            //}
            #endregion

            #region P2
            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write(number * i);

            //    if (i < 12)
            //    {
            //        Console.Write(", ");
            //    }
            //}
            #endregion

            #region P3
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= number; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write(i);

            //        if (i < number - 1)
            //        {
            //            Console.Write(", ");
            //        }
            //    }
            //}
            #endregion

            #region P4
            //Console.Write("Enter the base number: ");
            //int baseNumber = int.Parse(Console.ReadLine());

            //Console.Write("Enter the exponent: ");
            //int exponent = int.Parse(Console.ReadLine());

            //int result = 1;

            //for (int i = 1; i <= exponent; i++)
            //{
            //    result *= baseNumber;
            //}

            //Console.WriteLine($"Result: {result}");
            #endregion

            #region P5
            //Console.Write("Enter a string: ");
            //string text = Console.ReadLine();

            //for (int i = text.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(text[i]);
            //}
            #endregion

            #region P6
            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());

            //int reversed = 0;

            //while (number != 0)
            //{
            //    int digit = number % 10;
            //    reversed = reversed * 10 + digit;
            //    number /= 10;
            //}

            //Console.WriteLine($"Reversed number: {reversed}");
            #endregion

            #region P7
            //Console.Write("Enter the size of the array: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] numbers = new int[n];

            //// Read array values from the user
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Enter element {i + 1}: ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}

            //int maxDistance = 0;

            //// Find the longest distance between identical elements
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = i + 1; j < n; j++)
            //    {
            //        if (numbers[i] == numbers[j])
            //        {
            //            int distance = j - i - 1;

            //            if (distance > maxDistance)
            //            {
            //                maxDistance = distance;
            //            }
            //        }
            //    }
            //}

            //Console.WriteLine($"Longest distance: {maxDistance}");
            #endregion

            #region P8
            //Console.Write("Enter a sentence: ");
            //string sentence = Console.ReadLine();

            //string[] words = sentence.Split(' ');

            //Array.Reverse(words);

            //Console.WriteLine(string.Join(" ", words));
            #endregion
        }

        // Belongs to Problem1
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

        // Belongs to Problem9
        public static void SumAndMultiply(int x, int y, out int sum, out int product)
        {
            sum = x + y;
            product = x * y;
        }

        // Belongs to Problem10
        public static void PrintString(string text, int times = 5)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine(text);
            }
        }

        // Belongs to Problem13
        public static int SumArray(params int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum;
        }


    }
}

