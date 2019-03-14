using System;
namespace Algorithms_and_data_structures
{
    internal static class QuickSort
    {
        private static void Quick_Sort(int[] quicksize, int left, int right)
        {
            if (left < right)
            {
                int pivot = Sorting(quicksize, left, right);

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
        private static int Sorting(int[] quicksize, int left, int right)
        {
            int pivot = quicksize[left]; //pivot is chose element in sorted array (it can be left, mid, right, first, last or random)
            while (true)
            {
                while (quicksize[left] < pivot) //until pivot is bigger than left side, left++
                {
                    left++;
                }
                while (quicksize[right] > pivot) //until right side is bigger than pivot, right--
                {
                    right--;
                }
                if (left < right)
                {
                    int temp = quicksize[left];
                    quicksize[left] = quicksize[right]; //swap
                    quicksize[right] = temp;

                    if (quicksize[left] == quicksize[right]) //if same numbers
                        left++;
                }
                else
                {
                    return right; //if conditions are not met then return right side
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
            Quick_Sort(quicksize, 0, quicksize.Length - 1); //left 0 and right is length of array - 1
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Sorted array: ");
            foreach (var item in quicksize)
            {
                Console.Write(item + " ");
            }
            Console.ResetColor();
        }
    }
}
