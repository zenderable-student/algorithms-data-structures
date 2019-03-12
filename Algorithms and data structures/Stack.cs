using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_data_structures
{
    public class Stack
    {
        public static int StackSize() //size of the stack
        {
            int x;
            Console.WriteLine("Declare the size of the stack: ");
            while (!int.TryParse(Console.ReadLine(), out x) || !(x >= 0))
                Console.Write("Type number: ");
            return x;
        }
        
        public static int x = StackSize();
        public static int top = -1;
        public static readonly int[] tabStack = new int [x]; //here StackSize()

        public static void Push(int value) //push - to add item
        {
            //check it's full or not
            if (top == x-1) //here Rozmiar() - 1
            {
                Console.WriteLine("\nStack is FULL (or overflow)");
            }
            else
            {
                top++;
                tabStack[top] = value;
            }
        }
        public static void Pop() //pop - to remove item
        {
            //check it's empty or not
            if (top == -1) //because array is counted from 0
            {
                Console.WriteLine("\nStack is EMPTY (or underflow)");
            }
            else
                top--; //remove from top
        }
        public static void Display() //display - to view output
        {
            if(top == -1) //because array is counted from 0, so if size is 0 or it's empty there is nothing to display
            {
                Console.WriteLine("\nNothing to display!");
            }
            else
            {
                Console.Write("\nArray is: "); //show from top to bottom
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine(tabStack[i]);
                }
            }
        }
    }
}
