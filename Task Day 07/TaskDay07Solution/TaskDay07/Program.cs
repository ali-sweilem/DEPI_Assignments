using System;

namespace TaskDay07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Default ctor
            Car c1 = new Car();

            // Ctor with one Parameter(Id)
            Car c2 = new Car(1);

            // Ctor with two Parameter(Id, Brand)
            Car c3 = new Car(2, "BMW");

            Car c4 = new Car(3, "TOYOTA", 1500000);

            Console.WriteLine($"{c1.Id} - {c1.Brand} - {c1.Price}");
            Console.WriteLine($"{c2.Id} - {c2.Brand} - {c2.Price}");
            Console.WriteLine($"{c3.Id} - {c3.Brand} - {c3.Price}");
            Console.WriteLine($"{c4.Id} - {c4.Brand} - {c4.Price}");

        }
    }
}
