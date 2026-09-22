using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDay10.Problem2
{
    delegate int CompareDelegate<T>(T x, T y);
    internal static class SortingTwo<T>
    {
        public static void Sort(T[] items, CompareDelegate<T> compare)
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
