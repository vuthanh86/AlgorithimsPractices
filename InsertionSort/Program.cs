using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace InsertionSort
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine ("Insertion Sort");
            var random = new Random ();
            var searchList = Enumerable.Range (1, 10000).Select(x => random.Next (20000)).ToArray();
             var sw = new Stopwatch();
            sw.Start ();
            InsertionSort(searchList);
            sw.Stop();
            System.Console.WriteLine($"Sort completed. Total times = {sw.ElapsedMilliseconds} ms.");
        }

        static void InsertionSort (int[] array)
        {
            int inner, temp;
            for (int outer = 1; outer <= array.Length - 1; outer++)
            {
                temp = array[outer];
                inner = outer;
                while (inner > 0 && array[inner - 1] >= temp)
                {
                    array[inner] = array[inner - 1];
                    inner -= 1;
                }
                array[inner] = temp;
            }
        }
    }
}