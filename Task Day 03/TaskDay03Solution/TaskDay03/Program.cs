using System;
using System.Text;

namespace TaskDay03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem1
            //string input = Console.ReadLine();

            //int conv1 = int.Parse(input);
            //Console.WriteLine(conv1);

            //int conv2 = Convert.ToInt32(input);
            //Console.WriteLine(conv2);
            #endregion

            #region Problem2
            //Console.WriteLine("Enter any number");
            //int count;
            //string inpute = Console.ReadLine();

            //if (int.TryParse(inpute, out count))
            //{
            //    Console.WriteLine(count);
            //}
            //else
            //{
            //    Console.WriteLine("Numbers only");
            //}
            #endregion

            #region Problem3
            //object value;

            //value = 10;
            //Console.WriteLine(value.GetHashCode());

            //value = "Ali";
            //Console.WriteLine(value.GetHashCode());

            //value = 10.5;
            //Console.WriteLine(value.GetHashCode());
            #endregion

            #region Problem4
            //Person p1 = new Person();  // new object
            //p1.name = "Test"; // set name "Test"

            //Person p2 = p1; // create pointer refer to p1 (not create new object).
            //p2.name = "Ali"; // update name from "Test" to "Ali".

            //Console.WriteLine(p1.name); // print Ali
            //Console.WriteLine(p2.name); // print Ali
            #endregion

            #region Problem5
            //string text = "Hello";

            //// Before
            //Console.WriteLine($"Before: {text.GetHashCode()}");

            //text = text + "Hi Willy";
            //// After
            //Console.WriteLine($"After: {text.GetHashCode()}");
            #endregion

            #region Problem6
            //StringBuilder st = new StringBuilder("Hello");

            ////Before
            //Console.WriteLine($"Before: {st.GetHashCode()}");

            //st.Append("Willy");
            ////After
            //Console.WriteLine($"After: {st.GetHashCode()}");
            #endregion

            #region Problem7
            //Console.WriteLine("Enter first num");
            //int input1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter second num");
            //int inpute = int.Parse(Console.ReadLine());

            //int sum = input1 + inpute;

            //// Cocatination
            //Console.WriteLine("Sum is " + sum);

            //// Composite Formatting
            //Console.WriteLine(string.Format("Sum is {0}", sum));

            //// String Interpolation
            //Console.WriteLine($"Sum is {sum}");
            #endregion

            #region Problem8
            StringBuilder text = new StringBuilder("Hello World");
            // Append text
            text.Append(" test 1");
            Console.WriteLine("After append: " + text);

            // Replace a substring
            text.Replace("Hello", "Hi");
            Console.WriteLine("After Replace: " + text);

            // Insert a string at a specific position
            text.Insert(9, "Beautiful ");
            Console.WriteLine("After Insert: " + text);

            // Remove a portion of text
            text.Remove(6, 10);
            Console.WriteLine("After Remove: " + text);
            #endregion
        }
    }
}
