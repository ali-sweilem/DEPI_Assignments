using System;
using TaskDay07.Problem6;

namespace TaskDay07
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Problem1
            //// Default ctor
            //Car c1 = new Car();

            //// Ctor with one Parameter(Id)
            //Car c2 = new Car(1);

            //// Ctor with two Parameter(Id, Brand)
            //Car c3 = new Car(2, "BMW");

            //Car c4 = new Car(3, "TOYOTA", 1500000);

            //Console.WriteLine($"{c1.Id} - {c1.Brand} - {c1.Price}");
            //Console.WriteLine($"{c2.Id} - {c2.Brand} - {c2.Price}");
            //Console.WriteLine($"{c3.Id} - {c3.Brand} - {c3.Price}");
            //Console.WriteLine($"{c4.Id} - {c4.Brand} - {c4.Price}");
            #endregion

            #region Problem2
            //Calculator calculator = new Calculator();

            //// Two integers
            //Console.WriteLine(calculator.Sum(10, 20));

            //// Three integers
            //Console.WriteLine(calculator.Sum(10, 20, 30));

            //// Two doubles
            //Console.WriteLine(calculator.Sum(10.5, 20.5));
            #endregion

            #region Problem3
            //Child child = new Child(10, 15, 20);

            //Console.WriteLine($"X = {child.X}");
            //Console.WriteLine($"Y = {child.Y}");
            //Console.WriteLine($"Z = {child.Z}");
            #endregion

            #region Problem4
            //ChildNew childNew = new ChildNew(2, 3, 4);
            //Console.WriteLine(childNew.Product()); // 24

            //Parent parent1 = childNew;
            //Console.WriteLine(parent1.Product()); // 6

            //ChildOverride childOverride = new ChildOverride(2, 3, 4);
            //Console.WriteLine(childOverride.Product());

            //Parent parent2 = childOverride;
            //Console.WriteLine(parent2.Product());
            #endregion

            #region Problem5
            //Parent parent = new Parent(2,3);

            //Console.WriteLine(parent);

            //Child child = new Child(2, 3, 4);

            //Console.WriteLine(child);
            #endregion

            Rectangle rec = new Rectangle();

            rec.Width = 20;
            rec.Height = 5;

            Console.WriteLine($"Area = {rec.Area}");

            rec.Draw();

        }
    }
}
