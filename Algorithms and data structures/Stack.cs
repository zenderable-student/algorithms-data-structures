using System;

namespace Algorithms_and_data_structures
{
    public class Stack
    {
        private static int StackSize() //size of the stack
        {
            int x;
            Console.Write("Declare the size of the stack: ");
            while (!int.TryParse(Console.ReadLine(), out x) || !(x >= 0))
                Console.Write("Type number: ");
            return x;
        }
        private static readonly int X = StackSize();
        private static int _top = -1; //-1 because array is counted from 0 (so 0-1=-1)
        private static readonly int[] TabStack = new int [X]; //here StackSize()
        public static void StackMenu()
        {
            int choice;
            do
            {
                Console.Write("\n1. PUSH\n2. POP\n3. DISPLAY\n4. EXIT TO MENU\nYour choice: "); //pick option
                while (!int.TryParse(Console.ReadLine(), out choice) || !(choice >= 1 && choice <= 4))
                    Console.Write("Type '1' to '4': "); //if wrong, type correct integer
                if (choice == 1) //push
                {
                    Console.Write("Enter value: ");
                    int value;
                    while (!int.TryParse(Console.ReadLine(), out value))
                        Console.Write("Type value: ");
                    Push(value); //add item
                }
                if (choice == 2) //pop
                {
                    Pop(); //remove item
                }
                if (choice == 3) //display
                {
                    Display(); //view
                }
            } while (choice != 4); //exit, end of loop
        }
        private static void Push(int value) //push - to add item
        {
            //check it's full or not
            if (_top == X-1) //here StackSize() - 1
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nStack is FULL (or overflow)");
                Console.ResetColor();
            }
            else
            {
                _top++;
                TabStack[_top] = value;
            }
        }
        private static void Pop() //pop - to remove item
        {
            //check it's empty or not
            if (_top == -1) //because array is counted from 0
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nStack is EMPTY (or underflow)");
                Console.ResetColor();
            }
            else
                _top--; //remove from top
        }
        private static void Display() //display - to view output
        {
            if(_top == -1) //because array is counted from 0, so if size is 0 or it's empty there is nothing to display
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nNothing to display!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nThis is your stack: "); //show from top to bottom
                for (int i = 0; i <= _top; i++)
                {
                    Console.WriteLine(TabStack[i]);
                }
                Console.ResetColor();
            }
        }
    }
}