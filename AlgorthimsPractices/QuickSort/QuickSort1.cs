/*
 *  C# Program to Implement Quick Sort
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sortQuickAlgorithm
{
    public class QuickSort1
    {

        public int[] array = new int[20];
        public int len;

        public void QuickSortAlgorithm()
        {
            Sort(0, len - 1);
        }

        public void Sort(int left, int right)
        {
            int pivot, leftend, rightend;

            leftend = left;
            rightend = right;
            pivot = array[left];

            while (left < right)
            {
                while ((array[right] >= pivot) && (left < right))
                {
                    right--;
                }

                if (left != right)
                {
                    array[left] = array[right];
                    left++;
                }

                while ((array[left] >= pivot) && (left < right))
                {
                    left++;
                }

                if (left != right)
                {
                    array[right] = array[left];
                    right--;
                }
            }

            array[left] = pivot;
            pivot = left;
            left = leftend;
            right = rightend;

            if (left < pivot) { Sort(left, pivot - 1); }
            if (right > pivot)
            {
                Sort(pivot + 1, right);
            }
        }

        //public static void Main()
        //{
        //    QuickSort1 qSort = new QuickSort1();

        //    int[] array = { 41, 32, 15, 45, 63, 72, 57, 43, 32, 52, 183 };
        //    qSort.array = array;
        //    qSort.len = qSort.array.Length;
        //    qSort.QuickSortAlgorithm();

        //    for (int j = 0; j < qSort.len; j++)
        //    {
        //        Console.WriteLine(qSort.array[j]);
        //    }
        //    Console.ReadKey();
        //}
    }
}