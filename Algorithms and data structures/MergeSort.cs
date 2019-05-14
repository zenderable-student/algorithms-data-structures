using System;

namespace Algorithms_and_data_structures
{
    public static class MergeSort
    {
        private static int ArraySizeMethod()
        {
            int arrayAmount;
            Console.Write("Type amount of your numbers: ");
            while (!int.TryParse(Console.ReadLine(), out arrayAmount) || !(arrayAmount > 0))
                Console.Write("Something wrong! Type again: ");
            return arrayAmount;
        }
        private static readonly int X = ArraySizeMethod(); //size of the array to sort
        private static readonly int[] ArraySize = new int[X]; //array to sort
        private static readonly int[] ArraySizeSecondary = new int[X]; //secondary array (for help)
        static void Merging(int beg, int end) //beg - beginning of first array, end - end of second array
        {
            //copy values to secondary array
            for (var i = beg; i <= end; i++)
            {
                ArraySizeSecondary[i] = ArraySize[i];
            }
            //merge array
            int b = beg;
            int e = (beg + end) / 2 + 1; //second array has index from(("beg" + "end") / 2) + 1 to "end"
            int x = beg;
            while (b <= (beg + end) / 2 && e <= end) // first array has index from "beg" to ("beg" + "end") / 2
            {
                if (ArraySizeSecondary[b] < ArraySizeSecondary[e])
                {
                    ArraySize[x] = ArraySizeSecondary[b];
                    x++;
                    b++;
                }
                else
                {
                    ArraySize[x] = ArraySizeSecondary[e];
                    x++;
                    e++;
                }
            }
            //rewrite ending
            while (b <= (beg + end) / 2)
            {
                ArraySize[x] = ArraySizeSecondary[b];
                x++;
                b++;
            }
        }
        static void Sorting(int beg, int end) //beg - beginning of array to sort, end - ending of array to sort
        {
            if (beg < end)
            {
                //split the sorted array in half
                Sorting(beg, (beg + end) / 2);
                Sorting((beg + end) / 2 + 1, end);
                //merge sorted arrays
                Merging(beg, end);
            }
        }
        public static void Merge()
        {
            for (int i = 0; i <= ArraySize.Length - 1; i++)
            {
                Console.Write($"Type your {i + 1} number: ");
                int number;
                while (!int.TryParse(Console.ReadLine(), out number))
                    Console.Write($"Something wrong! Type again {i + 1} number: ");
                ArraySize[i] = number;
            }
            //use merge sort
            Sorting(0, ArraySize.Length - 1);
            //show sorted array
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Sorted array: ");
            foreach (var item in ArraySize)
            {
                Console.Write(item + " ");
            }
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
