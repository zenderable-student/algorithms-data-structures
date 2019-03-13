﻿using System;

namespace Algorithms_and_data_structures
{
    class BinarySearch
    {
        private static int Search(int[] array, int x)
        {
            int left = 0, right = array.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (array[mid] == x) //check if x is at mid
                    return mid;
                if (array[mid] < x) //if x is bigger, ignore left half
                    left = mid + 1;
                else //if x is smaller, ignore right half
                    right = mid - 1;
            }
            return -1; //element not found
        }
        public static void BinarySearchMenu()
        {
            int binarySearchArraySize;
            Console.Write("Type amount of your numbers: ");
            while (!int.TryParse(Console.ReadLine(), out binarySearchArraySize) || !(binarySearchArraySize > 0))
                Console.Write("Something wrong! Type again: ");
            int[] array = new int[binarySearchArraySize];
            for (int i = 0; i <= array.Length - 1; i++)
            {
                Console.Write($"Type {i + 1} number: ");
                int number;
                while (!int.TryParse(Console.ReadLine(), out number))
                    Console.Write($"Something wrong! Type again {i + 1} number: ");
                array[i] = number;
            }
            int numToSearch;
            Console.Write("What number would you like to search? Type: ");
            while (!int.TryParse(Console.ReadLine(), out numToSearch))
                Console.Write("Something wrong! Type again: ");
            int result = Search(array, numToSearch);
            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at " + "index " + result);
        }
    }
}