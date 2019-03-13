using System;

namespace Algorithms_and_data_structures
{
    class BinarySearch
    {
        private static int binarySearch(int[] arr, int x)
        {
            int l = 0, r = arr.Length - 1;
            while (l <= r)
            {
                int m = l + (r - l) / 2;

                // Check if x is present at mid 
                if (arr[m] == x)
                    return m;
                // If x greater, ignore left half 
                if (arr[m] < x)
                    l = m + 1;
                // If x is smaller, ignore right half 
                else
                    r = m - 1;
            }
            return -1; //element not found
        }
        public static void BinarySearchMenu()
        {
            int binarySearchArraySize;
            Console.Write("Type amount of your numbers: ");
            while (!int.TryParse(Console.ReadLine(), out binarySearchArraySize) || !(binarySearchArraySize > 0))
                Console.Write("Something wrong! Type again: ");
            int[] arr = new int[binarySearchArraySize];
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                Console.Write($"Type {i + 1} number: ");
                int number;
                while (!int.TryParse(Console.ReadLine(), out number))
                    Console.Write($"Something wrong! Type again {i + 1} number: ");
                arr[i] = number;
            }
            int x;
            Console.Write("What number would you like to search? Type: ");
            while (!int.TryParse(Console.ReadLine(), out x))
                Console.Write("Something wrong! Type again: ");
            int result = BinarySearch.binarySearch(arr, x);
            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at " + "index " + result);
        }
    }
}