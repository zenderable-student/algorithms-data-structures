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
            int value, choice;
            new Stack(); //I know it's strange, but it's working
            do
            {
                Console.Write("1. PUSH\n2. POP\n3. DISPLAY\n4. EXIT TO MENU\n\nYour choice: "); //pick option
                while (!int.TryParse(Console.ReadLine(), out choice) || !(choice >= 1 && choice <= 4))
                    Console.Write("Type '1' to '4': "); //if wrong, type correct integer
                if (choice == 1) //push
                {
                    Console.Write("Enter value: ");
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
            if (_top == X-1) //here Rozmiar() - 1
            {
                Console.WriteLine("\nStack is FULL (or overflow)");
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
                Console.WriteLine("\nStack is EMPTY (or underflow)");
            }
            else
                _top--; //remove from top
        }
        private static void Display() //display - to view output
        {
            if(_top == -1) //because array is counted from 0, so if size is 0 or it's empty there is nothing to display
            {
                Console.WriteLine("\nNothing to display!");
            }
            else
            {
                Console.WriteLine("\nThis is your stack: "); //show from top to bottom
                for (int i = 0; i <= _top; i++)
                {
                    Console.WriteLine(TabStack[i]);
                }
            }
        }
    }
}