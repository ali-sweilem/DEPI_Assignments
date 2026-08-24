using System;

namespace TaskDay03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int conv1 = int.Parse(input);
            Console.WriteLine(conv1);

            int conv2 = Convert.ToInt32(input);
            Console.WriteLine(conv2);

        }
    }
}
