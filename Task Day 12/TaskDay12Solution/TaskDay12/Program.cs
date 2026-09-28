using System;
using System.Linq;

namespace TaskDay12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-------------------- LINQ - Restriction Operators -----------------------/
            #region Problem1
            //Func<Product, bool> Predicate01 = ProductFilter.IsOutOfStock;

            //var Res0 = ListGenerators.ProductList.Where(Predicate01);

            //foreach (var res in Res0)
            //{
            //    Console.WriteLine(res);
            //}
            #endregion

            #region Problem2
            //var Res2 = ListGenerators.ProductList.Where((P) => P.UnitsInStock > 0 && P.UnitPrice > 3);

            //foreach (var Unit in Res2)
            //{
            //    Console.WriteLine(Unit);
            //}
            #endregion

            #region Problem3
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var Res = Arr.Where((Name, Index) => Name.Length <  Index);

            //foreach (var i in Res)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            //-------------------- LINQ - Element Operators -----------------------/

            #region Problem1
            //var Res = ListGenerators.ProductList.First(P => P.UnitsInStock == 0);

            //Console.WriteLine(Res);
            #endregion

            #region Problem2
            //var Res1 = ListGenerators.ProductList.FirstOrDefault(P => P.UnitPrice > 1000);

            //Console.WriteLine(Res1);
            #endregion

            #region Problem3
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Reasult = Arr.Where(A => A > 5).ElementAt(1);

            //Console.WriteLine(Reasult);
            #endregion

            //-------------------- LINQ - Aggregate Operators -----------------------/

            #region Problem1
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Res = Arr.Count(N => N % 2 != 0);

            //Console.WriteLine(Res);
            #endregion

            #region Problem2
            //var Result = ListGenerators.CustomerList.Select(C => new
            //{
            //    CustomerName = C.Name,
            //    OrderCount = C.Orders.Count()
            //});

            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"{item.CustomerName} : {item.OrderCount}");
            //}
            #endregion

            #region Problem3
            //var Result = ListGenerators.ProductList
            //    .GroupBy(P => P.Category)
            //    .Select(G => new 
            //    {
            //        PCategory = G.Key,
            //        PCount = G.Count()
            //    });

            //foreach (var Item in Result)
            //{
            //    Console.WriteLine($"{Item.PCategory} : {Item.PCount}");
            //}
            #endregion

            #region Problem4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = Arr.Sum();

            //Console.WriteLine(Result);
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
        public static bool IsInOfStock(Product product)
        {
            return product.UnitsInStock > 0;
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
