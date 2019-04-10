using System;
using System.Diagnostics;

namespace QuickSort
{
    class Program
    {
        //static int Partition(int[] numbers, int left, int right)
        //{
        //    var pivot = numbers[left];
        //    while (true)
        //    {
        //        while (numbers[left] < pivot)
        //            left++;

        //        while (numbers[right] > pivot)
        //            right--;

        //        if (left < right)
        //        {
        //            var temp = numbers[right];
        //            numbers[right] = numbers[left];
        //            numbers[left] = temp;
        //        }
        //        else
        //        {
        //            return right;
        //        }
        //    }
        //}
        //static void QuickSort_Recursive(int[] arr, int left, int right)
        //{
        //    // For Recusrion
        //    if (left < right)
        //    {
        //        var pivot = Partition(arr, left, right);

        //        if (pivot > 1)
        //            QuickSort_Recursive(arr, left, pivot - 1);

        //        if (pivot + 1 < right)
        //            QuickSort_Recursive(arr, pivot + 1, right);
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    var random = new Random();
        //    var arrays = new int[random.Next(1000)];

        //    for (var i = 0; i < arrays.Length - 1; i++)
        //    {
        //        arrays[i] = random.Next(random.Next(1000));
        //    }

        //    var sw = new Stopwatch();
        //    sw.Start();
        //    Console.WriteLine("QuickSort By Recursive Method");
        //    QuickSort_Recursive(arrays, 0, arrays.Length - 1);
        //    sw.Stop();
        //    Console.WriteLine($"Sorting time = {sw.ElapsedMilliseconds} ms.");
            
        //    Console.ReadLine();

        //}


        private int[] array = new int[20];
        private int len;

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

        static void Main()
        {
            var random = new Random();

            var qSort = new QuickSort1();

            var arrays = new int[random.Next(1000)];

            for (var i = 0; i < arrays.Length - 1; i++)
            {
                arrays[i] = random.Next(random.Next(1000));
            }
            var sw = new Stopwatch();
            sw.Start();
            qSort.array = arrays;
            qSort.len = qSort.array.Length;
            qSort.QuickSortAlgorithm();
            sw.Stop();
            Console.WriteLine("Time = " + sw.ElapsedMilliseconds + " ms");
            //for (int j = 0; j < qSort.len; j++)
            //{
            //    Console.WriteLine(qSort.array[j]);
            //}
            Console.ReadKey();
        }

        class QuickSort1
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
}
