using System;

namespace Depi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem1
                /*
                    The Program:
                    1. Store two nubers in x and y
                    2. Calculate their sum
                    3. Print the sum 
                 */

                //int x = 10; // Store the first number in temporary memory to use later
                //int y = 20; // Store the second number in temporary memory to use later
                //int sum = x + y; // Calculate the sum and store it in temporary memory to use later

                //Console.WriteLine(sum); // Print the sum
            #endregion

            #region Problem2
                //int x = "10";   // Syntax Error - Because x take integer not string --> the correct "int x = 10;"
                //console.WriteLine(x + y); // Synax Error --> the correct "Console with Capital C"  
            #endregion

            #region Problem3
                //string fullname = "ali ashour";
                //int age = 22;
                //double monthlysalary = 50000.00;
                //bool isstudent = true;
            #endregion

            #region Problem4
                //student student1 = new student();
                //student student2 = student1; // make student2 refere to the object that is refranced by student2
                //student1.name = "ali";

                //console.writeline(student1.getname()); // print 'ali'
                //console.writeline(student2.getname()); // print also 'ali'
            #endregion

            #region Problem5
            //int x = 15;
            //int y = 4;

            //int sum = x + y;

            //int diff = x - y;

            //int Product = x * y;

            //double division = x / y; // an int can be safly cast into a double

            //int remainder = x % y;
            #endregion

            #region Problem6
            //public bool CheckNum(int num)
            //{
            //    bool flag = false;

            //    if (num > 10 && num % 2 == 0)
            //    {
            //        flag = true;
            //        return flag;
            //    }

            //    return flag;
            //}
            #endregion

            #region Problem7
            //public void Casting(double num)
            //{
            //    int Explicity = (int)num; // Explicity it is potentially unsafe and could lose data

            //    double Implicity = Explicity; // Implicitly it is safe because no information can be lost
            //}
            #endregion

            #region Problem8
            //Console.WriteLine("Enter your age:");

            //string AgeInput = Console.ReadLine();

            //int Age = int.Parse(AgeInput);

            //if (Age > 0) 
            //{
            //    Console.WriteLine("Valid age");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid age");
            //}
            #endregion

            #region Problem8
                //int x = 5;

                //Console.WriteLine(++x); // 6 (Prefix)
                //Console.WriteLine(x++); // 6 (Postfix)
                //Console.WriteLine(x);   // 7
            #endregion


        }
    }
}
