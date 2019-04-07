using System;
using System.Diagnostics;
using System.Linq;

namespace BinarySearch
{
    class Program
    {
        static void Main (string[] args)
        {
            var random = new Random ();

            var searchList = Enumerable.Range (1, 1000).Select (x => random.Next (2000)).Distinct ().OrderBy (x => x).ToArray ();

            var searchValue = searchList[random.Next (searchList.Length - 1)];

            System.Console.WriteLine ($"Start binary search value = {searchValue} with arr size = {searchList.Length}");
            var sw = new Stopwatch ();
            sw.Start ();

            var foundIdx = searchList.SafeBinarySearch (searchValue);
            var xxx = Array.BinarySearch (searchList, searchValue);
            sw.Stop ();
            System.Console.WriteLine ($"Finised search in total : {sw.ElapsedMilliseconds} ms.");
            if (foundIdx == -1)
                System.Console.WriteLine ("Search value does not exist in array.");
            else
                System.Console.WriteLine ($"Search completed. Found value at index = {foundIdx}.");

            if (xxx == -1)
                System.Console.WriteLine ("Search value does not exist in array.");
            else
                System.Console.WriteLine ($"Search completed. Found value at index = {xxx}.");
        }

    }

    public static class BinarySearchExtensions
    {
        private static int SearchRercursive (int[] lists, int searchVal, int lower, int upper)
        {
            if (lower > upper)
            {
                return -1;
            }
            else
            {
                var mid = (lower + upper) / 2;

                if (searchVal < lists[mid])
                    return SearchRercursive (lists, searchVal, lower, mid - 1);
                else if (searchVal == lists[mid])
                    return mid;
                else
                    return SearchRercursive (lists, searchVal, mid + 1, upper);
            }
        }

        public static int SafeBinarySearch (this int[] searchList, int val)
        {
            int upper, lower, mid;

            upper = searchList.Length - 1;
            lower = 0;
            // while (upper >= lower)
            // {
            //     mid = (upper + lower) / 2;

            //     if (searchList[mid] == val)
            //     {
            //         return mid;
            //     }

            //     if (searchList[mid] < val)
            //     {
            //         lower = mid + 1;
            //     }
            //     else if (searchList[mid] > val)
            //     {
            //         upper = mid - 1;
            //     }
            // }
            // return -1;
            return SearchRercursive(searchList, val, lower, upper);
        }
    }
}