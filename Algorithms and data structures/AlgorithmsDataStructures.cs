using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Algorithms_and_data_structures
{
    //A simple console app with all algorithms and data structures at my university (UKW)
    public class MainMenu
    {
        static void Main()
        {
            int first_choice = 0, picked_algorithm = 0;
            string navigation;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("************** KAROL STUMSKI ***************\n");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("* ALGORITHMS AND DATA STRUCTURES *\n");
            Console.ResetColor();
            Start:
            Console.WriteLine("Type '1' if you want check some algorithms\nType '2' if you want check some examples of data structures");
            Console.Write("Your choice: ");
            while (!int.TryParse(Console.ReadLine(), out first_choice) || !(first_choice >= 1 && first_choice <= 2))
                Console.Write("Type '1' or '2': ");
            if(first_choice == 1)
            {
                //list of all algorithms

                Algorithm_list:
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n* ALGORITHMS LIST *");
                Console.ResetColor();
                Console.WriteLine("\n1: Factorial\n2: Fibonacci number\n3: Bubble sort"); //here more algorithms
                Console.Write("\nPick number of algorithm: ");
                while (!int.TryParse(Console.ReadLine(), out picked_algorithm) || !(picked_algorithm >= 1 && picked_algorithm <= 3))
                    Console.Write("Type '1' to '3': ");
                switch (picked_algorithm)
                {

                    case 1:
                        AgainFactorial:
                        int picked_implementation_factorial;
                        ulong factorial_number;
                        Console.WriteLine("Type '1' if you want use iterative implementation of factorial\nType '2' if you want use recursive implementation of factorial");
                        Console.Write("Your choice: ");
                        while (!int.TryParse(Console.ReadLine(), out picked_implementation_factorial) || !(picked_implementation_factorial >= 1 && picked_implementation_factorial <= 2))
                            Console.Write("Type from '1' or '2': ");
                        switch (picked_implementation_factorial)
                        {
                            case 1:
                                Console.Write("\nType number: ");
                                while (!ulong.TryParse(Console.ReadLine(), out factorial_number))
                                    Console.Write("Wrong! Try again type number: ");
                                Console.Write($"Factorial number is {Factorial.Factorial_iterative(factorial_number)}\n");
                                TryAgainMenuFactorial:
                                Console.WriteLine("\nIf you want try again use this algorithm, type 'R'.\nIf you want back to algorithm list, type 'L'.\nIf you want back to main menu, type 'Q'");
                                Console.Write("Type: ");
                                navigation = Console.ReadLine();
                                if ((navigation == "R") || (navigation == "r"))
                                {
                                    goto AgainFactorial; //use again algorithm
                                }
                                if (navigation == "L" || navigation == "l")
                                {
                                    goto Algorithm_list; //list of algorithms
                                }
                                if (navigation == "Q" || navigation == "q")
                                {
                                    goto Start; //beginning
                                }
                                else
                                {
                                    goto TryAgainMenuFactorial; //navigation
                                }
                            case 2:
                                Factorial factorial = new Factorial();
                                Console.Write("\nType number: ");
                                while (!ulong.TryParse(Console.ReadLine(), out factorial_number))
                                    Console.Write("Wrong! Try again type number: ");
                                Console.Write($"Factorial number is {Factorial.Factorial_recursive(factorial_number)}\n");
                                TryAgainMenuFactorial2:
                                Console.WriteLine("\nIf you want try again use this algorithm, type 'R'.\nIf you want back to algorithms list, type 'L'.\nIf you want back to main menu, type 'Q'");
                                Console.Write("Type: ");
                                navigation = Console.ReadLine();
                                if ((navigation == "R") || (navigation == "r"))
                                {
                                    goto AgainFactorial; //again algorithm
                                }
                                if (navigation == "L" || navigation == "l")
                                {
                                    goto Algorithm_list; //list of algorithms
                                }
                                if (navigation == "Q" || navigation == "q")
                                {
                                    goto Start; //beginning
                                }
                                else
                                {
                                    goto TryAgainMenuFactorial2; //navigation
                                }
                        }
                        break;
                    case 2:
                        Fibonacci fibonacci = new Fibonacci();
                        AgainFib:
                        int picked_implementation_fibonacci=0;
                        Console.WriteLine("Type '1' if you want use iterative implementation of fibonacci numbers\nType '2' if you want use recursive implementation of fibonacci numbers");
                        Console.Write("Your choice: ");
                        while (!int.TryParse(Console.ReadLine(), out picked_implementation_fibonacci) || !(picked_implementation_fibonacci >= 1 && picked_implementation_fibonacci <= 2))
                            Console.Write("Type from '1' or '2': ");
                        switch (picked_implementation_fibonacci)
                        {
                            case 1:
                                ulong n;
                                Console.Write("\nType amount of fibonacci numbers: ");
                                while (!ulong.TryParse(Console.ReadLine(), out n))
                                    Console.WriteLine("\nType number: ");
                                Console.Write($"n-th number is {Fibonacci.Fib_iteratively(n)}\n");
                                TryAgainMenuFib:
                                Console.WriteLine(
                                    "\nIf you want try again use this algorithm, type 'R'.\nIf you want back to algorithm list, type 'L'.\nIf you want back to main menu, type 'Q'");
                                Console.Write("Type: ");
                                navigation = Console.ReadLine();
                                if ((navigation == "R") || (navigation == "r"))
                                {
                                    goto AgainFib; //use again this algorithm
                                }

                                if (navigation == "L" || navigation == "l")
                                {
                                    goto Algorithm_list; //list of algorithms
                                }

                                if (navigation == "Q" || navigation == "q")
                                {
                                    goto Start; //beginning
                                }
                                else
                                {
                                    goto TryAgainMenuFib; //navigation
                                }
                            case 2:
                                ulong m;
                                Console.Write("\nType amount of fibonacci numbers: ");
                                while (!ulong.TryParse(Console.ReadLine(), out m))
                                    Console.WriteLine("\nType number: ");
                                Console.Write($"n-th number is {Fibonacci.Fib_recursive(m)}\n");
                                TryAgainMenuFib2:
                                Console.WriteLine(
                                    "\nIf you want try again use this algorithm, type 'R'.\nIf you want back to algorithm list, type 'L'.\nIf you want back to main menu, type 'Q'");
                                Console.Write("Type: ");
                                navigation = Console.ReadLine();
                                if ((navigation == "R") || (navigation == "r"))
                                {
                                    goto AgainFib; //use again fibonacci implementation
                                }

                                if (navigation == "L" || navigation == "l")
                                {
                                    goto Algorithm_list; //go to list of algorithms
                                }

                                if (navigation == "Q" || navigation == "q")
                                {
                                    goto Start; //go to beginning
                                }
                                else
                                {
                                    goto TryAgainMenuFib2; //navigation
                                }
                        }
                        break;
                    case 3:
                        BubbleSort bubblesort = new BubbleSort();
                        int bubblesortamount;
                        //AgainBubbleSort:
                        Console.Write("\nType number: ");
                        while (!int.TryParse(Console.ReadLine(), out bubblesortamount) || !(bubblesortamount > 0))
                            Console.Write("Type again: ");
                        int[] bubblesize = new int[bubblesortamount];
                        break;

                }

            }
            if (first_choice == 2) //data structures
            {
                int picked_structure;
                DataStructuresList: //list of all examples of data structures
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n* DATA STRUCTURES LIST *");
                Console.ResetColor();
                Console.WriteLine("\n1: Stack");
                Console.Write("Pick number of data structure: ");
                while (!int.TryParse(Console.ReadLine(), out picked_structure) || !(picked_structure >= 1 && picked_structure <= 2))
                    Console.Write("Type '1' or '2': ");
                switch (picked_structure)
                {
                        case 1:
                           AgainStack:
                           int value, choice;
                           Stack stack = new Stack();
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
                                            Stack.Push(value); //add item
                                    }

                                    if (choice == 2) //pop
                                    {
                                            Stack.Pop(); //remove item
                                    }

                                    if (choice == 3) //display
                                    {
                                            Stack.Display(); //view
                                    }
                               } while (choice != 4); //exit, end of loop

                                    TryAgainMenuStack:
                                    Console.WriteLine(
                                        "\nIf you want try again use this data structure, type 'R'.\nIf you want back to data structures list, type 'L'.\nIf you want back to main menu, type 'Q'");
                                    Console.Write("Type: ");
                                    navigation = Console.ReadLine();
                                    if ((navigation == "R") || (navigation == "r"))
                                    {
                                        goto AgainStack; //again use stack data structure
                                    }

                                    if (navigation == "L" || navigation == "l")
                                    {
                                        goto DataStructuresList; //go to list of data structures
                                    }

                                    if (navigation == "Q" || navigation == "q")
                                    {
                                        goto Start; //go to beginning of the program
                                    }
                                    else
                                    {
                                        goto TryAgainMenuStack; //if wrong answer, repeat navigation menu
                                    }
                }
            }
            else
            {
                goto Start; //if wrong choice, repeat 
            }
            //end
            Console.ReadKey();
        }
    }
}
