using System;
using System.Security.Cryptography.X509Certificates;

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

            #region Problem3
            //// Create a 2D array: 3 students, 3 subjects
            //int[,] grades = new int[3, 3];

            //// Take input from the user
            //for (int student = 0; student < 3; student++)
            //{
            //    Console.WriteLine($"Enter grades for Student {student + 1}:");

            //    for (int subject = 0; subject < 3; subject++)
            //    {
            //        Console.Write($"Subject {subject + 1}: ");
            //        grades[student, subject] = int.Parse(Console.ReadLine());
            //    }

            //    Console.WriteLine();
            //}

            //// Print the grades
            //Console.WriteLine("Student Grades:");

            //for (int student = 0; student < 3; student++)
            //{
            //    Console.Write($"Student {student + 1}: ");

            //    for (int subject = 0; subject < 3; subject++)
            //    {
            //        Console.Write(grades[student, subject] + " ");
            //    }

            //    Console.WriteLine();
            //}
            #endregion

            #region Problem4
            //int[] arr = {1, 0, 5, 2, 6, 3};


            //// Print the original array
            //Console.WriteLine("Original Array");
            //PrintArray(arr);

            //// 1. Sort
            //Console.WriteLine("\n---Sort---");

            //Console.WriteLine("Before Sort:");
            //PrintArray(arr);

            //Array.Sort(arr);

            //Console.WriteLine("\nAfter Sort:");
            //PrintArray(arr);

            //// 2. Reverse
            //Console.WriteLine("\n---Reverse---");

            //Console.WriteLine("Before reverse:");
            //PrintArray(arr);

            //Array.Reverse(arr);

            //Console.WriteLine("\nAfter reverse:");
            //PrintArray(arr);

            //// 3. IndexOf
            //Console.WriteLine("\n---IndexOf---");

            //int value = 3;

            //Console.WriteLine ("Array: ");
            //PrintArray (arr);

            //int index = Array.IndexOf(arr, value);

            //Console.WriteLine($"\nIndexOf {value} = {index}");


            //// 4. Copy
            //Console.WriteLine("---Copy---");

            //Console.WriteLine("Original Array:");
            //PrintArray(arr);

            //Console.WriteLine("  Hash: " + arr.GetHashCode());

            //Console.WriteLine();


            //Console.WriteLine("Shallow copy");

            //int[] copiedArray;
            //copiedArray = arr;

            //PrintArray(copiedArray);
            //Console.WriteLine("  Hash: " + copiedArray.GetHashCode());

            //Console.WriteLine("\nDeep copy");

            //copiedArray = (int[])arr.Clone();
            //PrintArray(copiedArray);
            //Console.WriteLine("  Hash: " + copiedArray.GetHashCode());

            //// 5. Clear
            //Console.WriteLine("\n--- Clear ---");

            //Console.WriteLine("Before Clear:");
            //PrintArray(arr);

            //Array.Clear(arr, 0, arr.Length);

            //Console.WriteLine("\nAfter Clear:");
            //PrintArray(arr);
            #endregion

            #region Problem5
            //int[] arr = { 10, 20, 30, 40, 50, 60 };

            //// 1. for loop
            //Console.WriteLine("For Loop");

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"ID {i + 1}: {arr[i]}");
            //}

            //// 2. foreach
            //Console.WriteLine("Foreach Loop");

            //int count = 1;
            //foreach (int item in arr)
            //{
            //    Console.WriteLine($"ID {count}: {item}");
            //    count++;
            //}

            //// 3. While loop
            //Console.WriteLine("While Loop");

            //int index = 0;
            //while (index < arr.Length)
            //{
            //    Console.WriteLine($"ID {index + 1}: {arr[index]}");
            //    index++;
            //}
            #endregion

            #region Problem6
            //int num;
            //bool flag;
            //do
            //{
            //    Console.WriteLine("Enter a positive odd number:");
            //    flag= int.TryParse(Console.ReadLine(), out num);
            //} while (num <= 0 || num % 2 == 1 || !flag);
            #endregion

            #region Problem7
            //int[,] arr = 
            //{
            //    {1, 2, 3},
            //    {4, 5, 6},
            //    {7, 8, 9}
            //};

            //// Print the array in matrix format
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write(arr[i, j] + " ");
            //    }

            //    Console.WriteLine();
            //}
            #endregion

            #region Problem8
            //// 1. if else
            //Console.WriteLine("Enter the month number:");

            //int num;
            //bool flag = int.TryParse(Console.ReadLine(), out num);

            //if (num == 1)
            //    Console.WriteLine("Jan");
            //else if (num == 2)
            //    Console.WriteLine("Feb");
            //else if (num == 3)
            //    Console.WriteLine("Mar");
            //else if (num == 4)
            //    Console.WriteLine("Apr");
            //else if (num == 5)
            //    Console.WriteLine("May");
            //else
            //    Console.WriteLine("Invalid month number");

            //// 2. Switch statement

            //switch (num)
            //{
            //    case 1:
            //        Console.WriteLine("Jan");
            //        break;

            //    case 2:
            //        Console.WriteLine("Feb");
            //        break;

            //    case 3:
            //        Console.WriteLine("Mar");
            //        break;

            //    case 4:
            //        Console.WriteLine("Apr");
            //        break;

            //    case 5:
            //        Console.WriteLine("May");
            //        break;

            //    default:
            //        Console.WriteLine("Invalid month number");
            //        break;
            //}
            #endregion

            #region Problem9
            //// Create an array
            //int[] numbers = { 5, 2, 8, 2, 9, 2, 4 };

            //// Print the original array
            //Console.WriteLine("Original Array:");

            //foreach (int number in numbers)
            //{
            //    Console.Write(number + " ");
            //}

            //// Sort the array
            //Array.Sort(numbers);

            //Console.WriteLine("\n\nSorted Array:");

            //foreach (int number in numbers)
            //{
            //    Console.Write(number + " ");
            //}

            //// Ask the user for a value to search for
            //Console.Write("\n\nEnter a value to search for: ");
            //int value = int.Parse(Console.ReadLine());

            //// Find the first occurrence
            //int firstIndex = Array.IndexOf(numbers, value);

            //// Find the last occurrence
            //int lastIndex = Array.LastIndexOf(numbers, value);

            //// Display the results
            //Console.WriteLine("\nFirst occurrence index: " + firstIndex);
            //Console.WriteLine("Last occurrence index: " + lastIndex);
            #endregion

            #region Problem10
            //// Create an array of integers
            //int[] numbers = { 10, 20, 30, 40, 50 };

            //// Calculate the sum using for loop
            //int sumFor = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sumFor += numbers[i];
            //}

            //Console.WriteLine("Sum using for loop: " + sumFor);


            //// Calculate the sum using foreach loop
            //int sumForeach = 0;

            //foreach (int number in numbers)
            //{
            //    sumForeach += number;
            //}

            //Console.WriteLine("Sum using foreach loop: " + sumForeach);
            #endregion
        }

        // Method to print the array
        public static void PrintArray(int[] arr)
        {
            foreach (int number in arr)
            {
                Console.Write(number + " ");
            }
        }
    }
}