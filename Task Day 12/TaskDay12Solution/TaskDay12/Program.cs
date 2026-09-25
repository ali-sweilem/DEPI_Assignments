using System;
using System.Linq;

namespace TaskDay12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem1
            //Func<Product, bool> Predicate01 = ProductFilter.IsOutOfStock;

            //var Res0 = ListGenerators.ProductList.Where(Predicate01);

            //foreach (var res in Res0)
            //{
            //    Console.WriteLine(res);
            //}
            #endregion
        }
    }

    class ProductFilter
    {
        // info >> out of stock
        public static bool IsOutOfStock(Product product)
        {
            return product.UnitsInStock == 0;
        }
        // info >> Category : Condiments
        public static bool IsCondiments(Product product)
        {
            return product.Category == "Condiments";
        }
        public static bool IsOutOfStockAndIsCondiments(Product product)
        {
            return product.Category == "Condiments" && product.UnitsInStock == 0;
        }
        public static bool IsOutOfStockInFirstTen(Product product, int index)
        {
            return product.UnitsInStock == 0 && index < 10;
        }
    }
}
