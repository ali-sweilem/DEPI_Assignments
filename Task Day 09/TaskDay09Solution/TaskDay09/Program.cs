using System;

namespace TaskDay09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (Weekdays day in Enum.GetValues(typeof(Weekdays)))
            {
                Console.WriteLine($"{day} = {(int)day}");
            }
        }

        public enum Weekdays
        {
            Monday = 1,
            Tuesday, 
            Wednesday,
            Thursday, 
            Friday
        }
    }
}
