using System;
namespace Algorithms_and_data_structures
{
    static class InsertionSort
    {
        public static void Sort()
        {
            int insertionsortamount;
            Console.Write("Type amount of your numbers: ");
            while (!int.TryParse(Console.ReadLine(), out insertionsortamount) || !(insertionsortamount > 0))
                Console.Write("Something wrong! Type again: ");
            int[] array = new int[insertionsortamount];
            for (int i = 0; i <= array.Length - 1; i++)
            {
                Console.Write($"Type {i + 1} number: ");
                int number;
                while (!int.TryParse(Console.ReadLine(), out number))
                    Console.Write($"Something wrong! Type again {i + 1} number: ");
                array[i] = number;
            }
            int val, flag;
            for (int i = 1; i < insertionsortamount; i++) //start sorting process
            {
                val = array[i];
                flag = 0;
                for (int j = i - 1; j >= 0 && flag != 1;) //in each loop, the current element is inserted into its correct position in the array
                {
                    if (val < array[j])
                    {
                        array[j + 1] = array[j];
                        j--;
                        array[j + 1] = val;
                    }
                    else flag = 1; //it's go until all is sorted
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Sorted Array: ");
            foreach (var sorted in array)
            {
                Console.Write(sorted + " ");
            }
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}