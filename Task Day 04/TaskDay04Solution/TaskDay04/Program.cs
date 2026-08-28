using System;

namespace TaskDay04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Using new int[size]
            int[] array1 = new int[3];

            array1[0] = 10;
            array1[1] = 20;
            array1[2] = 30;

            Console.WriteLine("Array 1:");
            foreach (int value in array1)
            {
                Console.WriteLine(value);
            }


            // 2. Using initializer list
            int[] array2 = new int[] { 40, 50, 60 };

            Console.WriteLine("\nArray 2:");
            foreach (int value in array2)
            {
                Console.WriteLine(value);
            }


            // 3. Using array syntax sugar
            int[] array3 = { 70, 80, 90 };

            Console.WriteLine("\nArray 3:");
            foreach (int value in array3)
            {
                Console.WriteLine(value);
            }


            // 4. Demonstrating IndexOutOfRangeException
            Console.WriteLine("\nTrying to access an invalid index:");

            try
            {
                Console.WriteLine(array1[3]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index is outside the bounds of the array.");
            }
        }
    }
}
