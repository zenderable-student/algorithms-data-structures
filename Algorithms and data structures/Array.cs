using System;
using System.Linq;

namespace Algorithms_and_data_structures
{
    internal static class Array
    {
        public static void ArrayMenu()
        {
            int arraySize, choice;
            Console.Write("Type amount of your numbers: ");
            while (!int.TryParse(Console.ReadLine(), out arraySize) || !(arraySize > 0))
                Console.Write("Something wrong! Type again: ");
            int[] array = new int[arraySize];
            for (int i = 0; i <= array.Length - 1; i++)
            {
                Console.Write($"Type your {i + 1} number (index {i}): ");
                int number;
                while (!int.TryParse(Console.ReadLine(), out number))
                    Console.Write($"Something wrong! Type again {i + 1} number: ");
                array[i] = number;
            }

            do
            {
                Console.Write("\n1. ADD VALUE\n2. REMOVE VALUE\n3. DISPLAY\n4. EXIT TO MENU\n\nYour choice: "); //pick option
                while (!int.TryParse(Console.ReadLine(), out choice) || !(choice >= 1 && choice <= 4))
                    Console.Write("Type '1' to '4': "); //if wrong, type correct integer
                if (choice == 1)
                {
                    int i, j;
                    Console.Write("Type number of index: ");
                    while (!int.TryParse(Console.ReadLine(), out i) || !(i >= 0 && i < array.Length))
                        Console.Write("Something wrong! Type again: ");
                    Console.Write("Type new value: ");
                    while (!int.TryParse(Console.ReadLine(), out j) || !(j > 0))
                        Console.Write("Something wrong! Type again: ");
                    array[i] = j;
                }
                if (choice == 2)
                {
                    int indexToRemove;
                    Console.Write("Type number of index to remove: ");
                    while (!int.TryParse(Console.ReadLine(), out indexToRemove) || !(indexToRemove >= 0))
                        Console.Write("Something wrong! Type again: ");
                    array = array.Where((source, index) => index != indexToRemove).ToArray(); //LINQ
                }
                if (choice == 3)
                {

                    foreach (var index in array)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(index + " ");
                        Console.ResetColor();
                    }
                }
            } while (choice != 4);
        }
    }
}
