using System;
using TaskDay08.Problem1;
using TaskDay08.Problem2;
using TaskDay08.Problem3;
using TaskDay08.Problem4;
using TaskDay08.Problem5;

namespace TaskDay08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem1
            //IVehicle car = new Car();
            //IVehicle bike = new Bike();

            //car.StartEngine();
            //car.StopEngine();

            //Console.WriteLine();

            //bike.StartEngine();
            //bike.StopEngine();
            #endregion

            #region Problem2
            //Shape rectangle = new Rectangle(5, 4);
            //Shape circle = new Circle(3);

            //rectangle.Display();
            //circle.Display();
            #endregion

            #region Problem3
            //Product[] products =
            //{
            //    new Product(1, "Laptop", 30000),
            //    new Product(2, "Mouse", 500),
            //    new Product(3, "Keyboard", 1200),
            //    new Product(4, "Monitor", 8000)
            //};

            //Console.WriteLine("Before Sorting:");

            //foreach (Product product in products)
            //{
            //    Console.WriteLine(product);
            //}

            //Array.Sort(products);

            //Console.WriteLine("\nAfter Sorting by Price:");

            //foreach (Product product in products)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region Problem4
            //Student original = new Student(1, "Ali", 90);

            //// Shallow copy
            //Student shallowCopy = original;

            //// Deep copy using copy constructor
            //Student deepCopy = new Student(original);

            //// Change the original object
            //original.Name = "Ahmed";
            //original.Grade = 80;

            //Console.WriteLine("Original:");
            //original.Display();

            //Console.WriteLine("\nShallow Copy:");
            //shallowCopy.Display();

            //Console.WriteLine("\nDeep Copy:");
            //deepCopy.Display();
            #endregion

            Robot robot = new Robot();

            // Calls Robot's own Walk() method
            robot.Walk();

            // Calls the explicit interface implementation
            IWalkable walkableRobot = robot;
            walkableRobot.Walk();
        }
    }
}
