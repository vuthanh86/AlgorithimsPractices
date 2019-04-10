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
            var searchList = Enumerable.Range (1, 10000).Select(x => random.Next (10000)).ToArray();
             var sw = new Stopwatch();
            sw.Start ();
            SafeSelectionSort(searchList);
            sw.Stop();
            System.Console.WriteLine($"Sort completed. Total times = {sw.ElapsedMilliseconds} ms.");
            Console.ReadLine();
        }

        static void SafeSelectionSort(int[] arrays)
        {
            for (int outer = 0; outer < arrays.Length - 1; outer++)
            {
                var min = outer;
                for (int inner = outer + 1; inner < arrays.Length - 1; inner++)
                {
                    if (arrays[inner] < arrays[min])
                    {
                        min = inner;
                    }
                    var temp = arrays[outer];
                    arrays[outer] = arrays[min];
                    arrays[min] = temp;
                }
            }
        }
    }
}
