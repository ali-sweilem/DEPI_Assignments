using System;

namespace TaskDay04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem1
            //// 1. Using new int[size]
            //int[] array1 = new int[3];

            //array1[0] = 10;
            //array1[1] = 20;
            //array1[2] = 30;

            //Console.WriteLine("Array 1:");
            //foreach (int value in array1)
            //{
            //    Console.WriteLine(value);
            //}


            //// 2. Using initializer list
            //int[] array2 = new int[] { 40, 50, 60 };

            //Console.WriteLine("Array 2:");
            //foreach (int value in array2)
            //{
            //    Console.WriteLine(value);
            //}


            //// 3. Using array syntax sugar
            //int[] array3 = { 70, 80, 90 };

            //Console.WriteLine("Array 3:");
            //foreach (int value in array3)
            //{
            //    Console.WriteLine(value);
            //}


            //// 4. Demonstrating IndexOutOfRangeException
            //Console.WriteLine("\nTrying to access an invalid index:");

            //try
            //{
            //    Console.WriteLine(array1[3]);
            //}
            //catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine("Index is outside the bounds of the array.");
            //}
            #endregion

            #region Problem2
            //// Create two array
            //int[] arr1 = {10, 20, 30, 40, 50};
            //int[] arr2;

            //// =========================
            //// Shallow Copy
            //// =========================

            //arr2 = arr1;

            //Console.WriteLine("Before modification:");
            //Console.WriteLine("arr1[0] = " + arr1[0]);
            //Console.WriteLine("arr2[0] = " + arr2[0]);

            //// Modify arr1
            //arr1[0] = 101;

            //Console.WriteLine("\nAfter modifying arr1:");
            //Console.WriteLine("arr1[0] = " + arr1[0]);
            //Console.WriteLine("arr2[0] = " + arr2[0]);

            //// =========================
            //// Deep Copy using Clone()
            //// =========================

            //int[] arr3 = (int[])arr1.Clone();

            //Console.WriteLine("\nBefore modification:");
            //Console.WriteLine("arr1[1] = " + arr1[1]);
            //Console.WriteLine("arr3[1] = " + arr3[1]);

            //// Modify arr1
            //arr1[1] = 200;

            //Console.WriteLine("\nAfter modifying arr1:");
            //Console.WriteLine("arr1[1] = " + arr1[1]);
            //Console.WriteLine("arr3[1] = " + arr3[1]);
            #endregion


            // Create a 2D array: 3 students, 3 subjects
            int[,] grades = new int[3, 3];

            // Take input from the user
            for (int student = 0; student < 3; student++)
            {
                Console.WriteLine($"Enter grades for Student {student + 1}:");

                for (int subject = 0; subject < 3; subject++)
                {
                    Console.Write($"Subject {subject + 1}: ");
                    grades[student, subject] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine();
            }

        }
    }
}
