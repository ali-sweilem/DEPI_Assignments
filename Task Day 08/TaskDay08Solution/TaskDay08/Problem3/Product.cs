using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDay08.Problem3
{
    internal class Product : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public int CompareTo(Product other)
        {
            return Price.CompareTo(other.Price);
        }


        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Price: {Price}";
        }

    }
}
