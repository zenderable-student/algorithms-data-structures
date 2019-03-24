using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_data_structures
{
    static class List
    {
        public static void ListMenu()
        {
            int choice;
            IList<int> intList = new List<int>();
            do
            {
                Console.Write("\n1. ADD VALUE\n2. REMOVE VALUE\n3. DISPLAY\n4. EXIT TO MENU\n\nYour choice: "); //pick option
                while (!int.TryParse(Console.ReadLine(), out choice) || !(choice >= 1 && choice <= 4))
                    Console.Write("Type '1' to '4': "); //if wrong, type correct integer
                if (choice == 1)
                {
                    int i;
                    Console.Write("Type number: ");
                    while (!int.TryParse(Console.ReadLine(), out i))
                        Console.Write("Something wrong! Type again: ");
                    intList.Add(i);
                }
                if (choice == 2)
                {
                    int valueToRemove;
                    Console.Write("Type number to remove: ");
                    while (!int.TryParse(Console.ReadLine(), out valueToRemove) || !(valueToRemove >= 0))
                        Console.Write("Something wrong! Type again: ");
                    intList.Remove(valueToRemove);
                }
                if (choice == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your array: ");
                    int i = 0;
                    foreach (var index in intList)
                    {
                        Console.WriteLine($"Index {i}: " + index);
                        i++;
                    }
                    Console.ResetColor();
                    Console.WriteLine();
                }
            } while (choice != 4);
        }
    }
}
