using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskDay10.Problem2;

namespace TaskDay10.Problem5
{
    internal static class SortingTwo<T>
    {
        public static void Sort(T[] items, Func<T,T,int> compare)
        {
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length - 1 - i; j++)
                {
                    if (compare(items[j], items[j + 1]) > 0)
                    {
                        Swap(ref items[j], ref items[j + 1]);
                    }
                }
            }
        }
        public static void Swap(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
