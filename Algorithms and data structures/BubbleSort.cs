using System;
namespace Algorithms_and_data_structures
{
    static class BubbleSort
    {
        public static void Bubble()
        {
            int bubblesortamount;
            int temp;
            Console.Write("Type amount of your numbers: ");
            while (!int.TryParse(Console.ReadLine(), out bubblesortamount) || !(bubblesortamount > 0))
                Console.Write("Something wrong! Type again: ");
            int[] bubblesize = new int[bubblesortamount];
            for (int i = 0; i <= bubblesize.Length - 1; i++)
            {
                Console.Write($"Type {i + 1} number: ");
                int number;
                while (!int.TryParse(Console.ReadLine(), out number))
                    Console.Write($"Something wrong! Type again {i+1} number: ");
                bubblesize[i] = number;
            }

            for (int j = 0; j <= bubblesize.Length - 2; j++)
            {
                for (int i = 0; i <= bubblesize.Length - 2; i++)
                {
                    if (bubblesize[i] > bubblesize[i + 1])
                    {
                        temp = bubblesize[i + 1];
                        bubblesize[i + 1] = bubblesize[i];
                        bubblesize[i] = temp;
                    }
                }
            }

            Console.Write("Sorted: ");
            foreach (int sorted in bubblesize)
            {
                Console.Write(sorted + " ");
            }
        }
    }
}
