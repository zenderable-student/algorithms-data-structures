using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_data_structures
{
    [Serializable()]
    public class Stack
    {
        public static int top = -1;
        public static int[] z = new int [5];

        public static void Push(int value)
        {
            if (top == 4)
            {
                Console.WriteLine("\nStack is FULL (or overflow)");
            }
            else
            {
                top++;
                z[top] = value;
            }
        }
        public static void Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("\nStack is EMPTY (or underflow)");
            }
            else
                top--;
        }
        public static void Display()
        {
            if(top == -1)
            {
                Console.WriteLine("\nNothing to display!");
            }
            else
            {
                Console.Write("\nArray is: ");
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine(z[i]);
                }
            }
        }
    }
}
