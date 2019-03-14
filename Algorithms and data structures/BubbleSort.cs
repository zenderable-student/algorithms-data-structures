using System;
namespace Algorithms_and_data_structures
{
    internal static class BubbleSort
    {
        public static void Bubble()
        {
            int bubblesortamount;
            Console.Write("Type amount of your numbers: ");
            while (!int.TryParse(Console.ReadLine(), out bubblesortamount) || !(bubblesortamount > 0))
                Console.Write("Something wrong! Type again: ");
            int[] bubblesize = new int[bubblesortamount];
            for (int i = 0; i <= bubblesize.Length - 1; i++)
            {
                Console.Write($"Type your {i + 1} number: ");
                int number;
                while (!int.TryParse(Console.ReadLine(), out number))
                    Console.Write($"Something wrong! Type again {i + 1} number: ");
                bubblesize[i] = number;
            }
            for (int i = 0; i < bubblesize.Length; i++) //i determines the number of n steps for sorting 
            {
                for (int j = bubblesize.Length - 1; j > i; j--) //j determines the number of comparisons (n-1) in each step and the indices to be studied for comparison
                {
                    if (bubblesize[j - 1] > bubblesize[j]) //if first element is bigger than 2nd element it will swap
                    {
                       
                        var temp = bubblesize[j]; 
                        bubblesize[j] = bubblesize[j - 1]; //swap,
                        bubblesize[j - 1] = temp;
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Sorted array: ");
            foreach (var sorted in bubblesize)
            {
                Console.Write(sorted + " ");
            }
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}