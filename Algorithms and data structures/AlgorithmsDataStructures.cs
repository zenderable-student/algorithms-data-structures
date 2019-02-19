using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Algorithms_and_data_structures
{
    //A simple console app with all algorithms and data structures at my university (UKW)
    class MainMenu
    {
        static void Main(string[] args)
        {
            int first_choice, picked_algorithm=0, picked_implementation;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("************** KAROL STUMSKI ***************");
            Console.ResetColor();
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("* ALGORITHMS AND DATA STRUCTURES *");
            Console.ResetColor();
            Console.WriteLine(" ");
            //Start:
            Console.WriteLine("Type '1' if you want check some algorithms");
            Console.WriteLine("Type '2' if you want check some examples of data structures");
            Console.Write("Your choice: ");
            while (!int.TryParse(Console.ReadLine(), out first_choice) || !(first_choice >= 1 && first_choice <= 2))
                Console.Write("Type '1' or '2': ");
            if(first_choice == 1)
            {
                //list of all algorithms
                Algorithms algorithms = new Algorithms();
                Algorithm_list:
                Console.WriteLine("1: Factorial");
                Console.WriteLine("2: Fibonacci number");
                Console.WriteLine("");
                Console.Write("Pick number of algorithm: ");
                while (!int.TryParse(Console.ReadLine(), out picked_algorithm) || !(picked_algorithm >= 1 && picked_algorithm <= 2))
                    Console.Write("Type '1' or '2': ");
                switch (picked_algorithm)
                {

                    case 1:
                        Again:
                        int factorial_number;
                        Console.WriteLine("Type '1' if you want use iterative implementation of factorial");
                        Console.WriteLine("Type '2' if you want use recursive implementation of factorial");
                        Console.Write("Your choice: ");
                        while (!int.TryParse(Console.ReadLine(), out picked_implementation) || !(picked_implementation >= 1 && picked_algorithm <= 2))
                            Console.Write("Type from '1' or '2': ");
                        switch (picked_implementation)
                        {
                            case 1:
                                Console.Write("Type number: ");
                                while (!int.TryParse(Console.ReadLine(), out factorial_number))
                                    Console.WriteLine("Type number: ");
                                Console.Write($"Factorial number is {Algorithms.factorial_iteratively(factorial_number)}");
                                break;
                            case 2:
                                Console.Write("Type number: ");
                                while (!int.TryParse(Console.ReadLine(), out factorial_number))
                                    Console.WriteLine("Type number: ");
                                Console.Write($"Factorial number is {Algorithms.factorial_recursive(factorial_number)}");
                                break;
                            default:
                                Console.WriteLine("Wrong number! Try again.");
                                goto Again;
                        }
                        break;
                    case 2:
                        int n;
                        Console.Write("Type amount of fibonacci numbers: ");
                        while (!int.TryParse(Console.ReadLine(), out n))
                            Console.WriteLine("Type number: ");
                        Console.Write($"n-th number is {Algorithms.fib(n)}");
                        break;
                    default:
                        Console.WriteLine("Wrong number! Try again.");
                        goto Algorithm_list;
                }

            }
            else
            {
                //ListOfDataStructures:
                //list of all examples of data structures
                Console.WriteLine("1: Stack (not working)");
            }


            Console.ReadKey();
        }
    }
}
