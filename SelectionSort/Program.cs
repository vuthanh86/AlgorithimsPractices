using System.Diagnostics;
using System.Collections.Immutable;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selection Sort Practice");
            var random = new Random ();
            var searchList = Enumerable.Range (1, 10000).Select(x => random.Next (20000)).ToArray();
             var sw = new Stopwatch();
            sw.Start ();
            searchList.SafeSelectionSort();
            sw.Stop();
            System.Console.WriteLine($"Sort completed. Total times = {sw.ElapsedMilliseconds} ms.");
        }
    }

    public static class SortExtensions
    {
        public static void SafeSelectionSort(this int[] arrays)
        {
            int min, temp;

            for (int outer = 0; outer < arrays.Length; outer++)
            {
                min = outer;
                for (int inner = outer + 1; inner < arrays.Length; inner++)
                {
                    if (arrays[inner] < arrays[min])
                    {
                        min = inner;
                    }
                    temp = arrays[outer];
                    arrays[outer] = arrays[min];
                    arrays[min] = temp;
                }
            }
        }
    }
}
