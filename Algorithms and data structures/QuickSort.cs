using System;
namespace Algorithms_and_data_structures
{
    internal static class QuickSort
    {
        private static void Quick_Sort(int[] quicksize, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(quicksize, left, right);

                if (pivot > 1)
                {
                    Quick_Sort(quicksize, left, pivot - 1);
                }

                if (pivot + 1 < right)
                {
                    Quick_Sort(quicksize, pivot + 1, right);
                }
            }
        }
        private static int Partition(int[] quicksize, int left, int right)
        {
            int pivot = quicksize[left];
            while (true)
            {
                while (quicksize[left] < pivot)
                {
                    left++;
                }
                while (quicksize[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    if (quicksize[left] == quicksize[right]) return right;

                    int temp = quicksize[left];
                    quicksize[left] = quicksize[right];
                    quicksize[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
        public static void QuickSortMenu()
        {
            int quicksortamount;
            Console.Write("Type amount of your numbers: ");
            while (!int.TryParse(Console.ReadLine(), out quicksortamount) || !(quicksortamount > 0))
                Console.Write("Something wrong! Type again: ");
            int[] quicksize = new int[quicksortamount];
            for (int i = 0; i <= quicksize.Length - 1; i++)
            {
                Console.Write($"Type your {i + 1} number: ");
                int number;
                while (!int.TryParse(Console.ReadLine(), out number))
                    Console.Write($"Something wrong! Type again {i + 1} number: ");
                quicksize[i] = number;
            }
            Quick_Sort(quicksize, 0, quicksize.Length - 1);
            Console.Write("Sorted array: ");
            foreach (var item in quicksize)
            {
                Console.Write(" " + item);
            }
        }
    }
}
