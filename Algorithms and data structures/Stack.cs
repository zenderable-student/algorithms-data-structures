﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_data_structures
{
    public class Stack
    {
        
        //// not working solution for size of the stack, will fix later ////
        public static int Rozmiar()
        {
            int x;
            Console.WriteLine("Declare the size of the stack: ");
            while (!int.TryParse(Console.ReadLine(), out x) || !(x >= 0))
                Console.Write("Type number: ");
            return x;
        }

        public static int x = Rozmiar();
        public static int top = -1;
        public static int[] z = new int [x]; //here Rozmiar()

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
                z[top] = value;
            }
        }
        public static void Pop() //pop - to remove item
        {
            //check it's empty or not
            if (top == -1)
            {
                Console.WriteLine("\nStack is EMPTY (or underflow)");
            }
            else
                top--;
        }
        public static void Display() //display - to view output
        {
            if(top == -1)
            {
                Console.WriteLine("\nNothing to display!");
            }
            else
            {
                Console.Write("\nArray is: "); //from top to bottom
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine(z[i]);
                }
            }
        }
    }
}
