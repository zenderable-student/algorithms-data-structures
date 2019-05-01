using System;

namespace Algorithms_and_data_structures
{
    //A simple console app with all algorithms and data structures at my university (UKW)
    public static class MainMenu
    {
        private static void Main()
        {
            string navigation;
            StartScreen(); //beginning of program
            Start:
            Console.WriteLine("Type '1' if you want check some algorithms\nType '2' if you want check some examples of data structures");
            Console.Write("Your choice: ");
            int firstChoice;
            while (!int.TryParse(Console.ReadLine(), out firstChoice) || !(firstChoice >= 1 && firstChoice <= 2))
                Console.Write("Type '1' or '2': ");
            if(firstChoice == 1)
            {
                Algorithm_list: //list of all algorithms
                AlgorithmsList();
                Console.Write("\nPick number of algorithm: ");
                int pickedAlgorithm;
                while (!int.TryParse(Console.ReadLine(), out pickedAlgorithm) || !(pickedAlgorithm >= 1 && pickedAlgorithm <= 7))
                    Console.Write("Type '1' to '7': ");
                switch (pickedAlgorithm)
                {
                    case 1: //Factorial
                        AgainFactorial:
                        int pickedImplementationFactorial;
                        Console.WriteLine("Type '1' if you want use iterative implementation of factorial\nType '2' if you want use recursive implementation of factorial");
                        Console.Write("Your choice: ");
                        while (!int.TryParse(Console.ReadLine(), out pickedImplementationFactorial) || !(pickedImplementationFactorial >= 1 && pickedImplementationFactorial <= 2))
                            Console.Write("Type from '1' or '2': ");
                        switch (pickedImplementationFactorial)
                        {
                            case 1:
                                Factorial.FactorialIterativelyMenu();
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
                                Factorial.FactorialRecursivelyMenu();
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
                    case 2: //Fibonacci numbers
                        AgainFib:
                        int pickedImplementationFibonacci;
                        Console.WriteLine("Type '1' if you want use iterative implementation of fibonacci numbers\nType '2' if you want use recursive implementation of fibonacci numbers");
                        Console.Write("Your choice: ");
                        while (!int.TryParse(Console.ReadLine(), out pickedImplementationFibonacci) || !(pickedImplementationFibonacci >= 1 && pickedImplementationFibonacci <= 2))
                            Console.Write("Type from '1' or '2': ");
                        switch (pickedImplementationFibonacci)
                        {
                            case 1:
                                Fibonacci.FibonacciIterativelyMenu();
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
                                Fibonacci.FibonacciRecursivelyMenu();
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
                    case 3: //Bubble Sort
                        AgainBubbleSort:
                        BubbleSort.Bubble();
                        TryAgainMenuBubble:
                        Console.WriteLine("\nIf you want try again use this algorithm, type 'R'.\nIf you want back to data structures list, type 'L'.\nIf you want back to main menu, type 'Q'");
                        Console.Write("Type: ");
                        navigation = Console.ReadLine();
                        if ((navigation == "R") || (navigation == "r"))
                        {
                            goto AgainBubbleSort; //again use Bubble Sort
                        }

                        if (navigation == "L" || navigation == "l")
                        {
                            goto Algorithm_list; //go to list of algorithms
                        }

                        if (navigation == "Q" || navigation == "q")
                        {
                            goto Start; //go to beginning of the program
                        }
                        else
                        {
                            goto TryAgainMenuBubble; //if wrong answer, repeat navigation menu
                        }
                    case 4: //Binary Search
                        AgainBinarySearch:
                        BinarySearch.BinarySearchMenu();
                        TryAgainMenuBinarySearch:
                        Console.WriteLine("\nIf you want try again use this algorithm, type 'R'.\nIf you want back to data structures list, type 'L'.\nIf you want back to main menu, type 'Q'");
                        Console.Write("Type: ");
                        navigation = Console.ReadLine();
                        if (navigation == "R" || navigation == "r")
                        {
                            goto AgainBinarySearch; //again use Binary Search
                        }

                        if (navigation == "L" || navigation == "l")
                        {
                            goto Algorithm_list; //go to list of algorithms
                        }

                        if (navigation == "Q" || navigation == "q")
                        {
                            goto Start; //go to beginning of the program
                        }
                        else
                        {
                            goto TryAgainMenuBinarySearch; //if wrong answer, repeat navigation menu
                        }
                        case 5: //Quick Sort
                        AgainQuickSort:
                        QuickSort.QuickSortMenu();
                        TryAgainMenuQuickSort:
                        Console.WriteLine("\nIf you want try again use this algorithm, type 'R'.\nIf you want back to data structures list, type 'L'.\nIf you want back to main menu, type 'Q'");
                        Console.Write("Type: ");
                        navigation = Console.ReadLine();
                        if (navigation == "R" || navigation == "r")
                        {
                            goto AgainQuickSort; //again use Quick Sort
                        }

                        if (navigation == "L" || navigation == "l")
                        {
                            goto Algorithm_list; //go to list of algorithms
                        }

                        if (navigation == "Q" || navigation == "q")
                        {
                            goto Start; //go to beginning of the program
                        }
                        else
                        {
                            goto TryAgainMenuQuickSort; //if wrong answer, repeat navigation menu
                        }
                        case 6:
                        AgainInsertionSort:
                        InsertionSort.Sort();
                        TryAgainMenuInsertionSort:
                        Console.WriteLine("\nIf you want try again use this algorithm, type 'R'.\nIf you want back to data structures list, type 'L'.\nIf you want back to main menu, type 'Q'");
                        Console.Write("Type: ");
                        navigation = Console.ReadLine();
                        if (navigation == "R" || navigation == "r")
                        {
                            goto AgainInsertionSort; //again use Insertion Sort
                        }

                        if (navigation == "L" || navigation == "l")
                        {
                            goto Algorithm_list; //go to list of algorithms
                        }

                        if (navigation == "Q" || navigation == "q")
                        {
                            goto Start; //go to beginning of the program
                        }
                        else
                        {
                            goto TryAgainMenuInsertionSort; //if wrong answer, repeat navigation menu
                        }
                        case 7:
                        AgainMergeSort:
                        MergeSort.Merge();
                        TryAgainMenuMergeSort:
                        Console.WriteLine("\nIf you want try again use this algorithm, type 'R'.\nIf you want back to data structures list, type 'L'.\nIf you want back to main menu, type 'Q'");
                        Console.Write("Type: ");
                        navigation = Console.ReadLine();
                        if (navigation == "R" || navigation == "r")
                        {
                            goto AgainMergeSort; //again use Merge Sort
                        }

                        if (navigation == "L" || navigation == "l")
                        {
                            goto Algorithm_list; //go to list of algorithms
                        }

                        if (navigation == "Q" || navigation == "q")
                        {
                            goto Start; //go to beginning of the program
                        }
                        else
                        {
                            goto TryAgainMenuMergeSort; //if wrong answer, repeat navigation menu
                        }
                        //case 8:
                }
            }
            if (firstChoice == 2) //data structures
            {
                DataStructuresList: //list of all examples of data structures
                DataStructuresList();
                Console.Write("Pick number of data structure: ");
                int pickedStructure;
                while (!int.TryParse(Console.ReadLine(), out pickedStructure) || !(pickedStructure >= 1 && pickedStructure <= 3))
                    Console.Write("Type '1' to '3': ");
                switch (pickedStructure)
                {
                case 1:
                     AgainStack:
                     Stack.StackMenu();
                     TryAgainMenuStack:
                     Console.WriteLine("\nIf you want try again use this data structure, type 'R'.\nIf you want back to data structures list, type 'L'.\nIf you want back to main menu, type 'Q'");
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
                case 2:
                AgainArray:
                Array.ArrayMenu();
                TryAgainMenuArray:
                Console.WriteLine("\nIf you want try again use this data structure, type 'R'.\nIf you want back to data structures list, type 'L'.\nIf you want back to main menu, type 'Q'");
                Console.Write("Type: ");
                navigation = Console.ReadLine();
                if ((navigation == "R") || (navigation == "r"))
                {
                    goto AgainArray; //again use stack data structure
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
                    goto TryAgainMenuArray; //if wrong answer, repeat navigation menu
                }
                case 3:
                AgainList:
                List.ListMenu();
                TryAgainListArray:
                Console.WriteLine("\nIf you want try again use this data structure, type 'R'.\nIf you want back to data structures list, type 'L'.\nIf you want back to main menu, type 'Q'");
                Console.Write("Type: ");
                navigation = Console.ReadLine();
                if ((navigation == "R") || (navigation == "r"))
                {
                    goto AgainList; //again use list data structure
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
                    goto TryAgainListArray; //if wrong answer, repeat navigation menu
                }
                case 4:
                AgainLinkedList:
                //LinkedList.Node();
                TryAgainLinkedListArray:
                Console.WriteLine("\nIf you want try again use this data structure, type 'R'.\nIf you want back to data structures list, type 'L'.\nIf you want back to main menu, type 'Q'");
                Console.Write("Type: ");
                navigation = Console.ReadLine();
                if ((navigation == "R") || (navigation == "r"))
                {
                    goto AgainLinkedList; //again use list data structure
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
                    goto TryAgainLinkedListArray; //if wrong answer, repeat navigation menu
                }
                    //case 5:
                }
            }
            else
            {
                goto Start; //if wrong choice, repeat 
            }
            //end
            Console.ReadKey();
        }
        private static void DataStructuresList()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n* DATA STRUCTURES LIST *");
            Console.ResetColor();
            Console.WriteLine("\n1: Stack\n2: Array\n3: List"); //here more data structures
        }
        private static void AlgorithmsList()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n* ALGORITHMS LIST *");
            Console.ResetColor();
            Console.WriteLine("\n1: Factorial\n2: Fibonacci number\n3: Bubble sort\n4: Binary search\n5: Quick sort\n6: Insertion sort\n7: Merge sort"); //here more algorithms
        }
        private static void StartScreen()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("************** KAROL STUMSKI ***************\n");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("* ALGORITHMS AND DATA STRUCTURES *\n");
            Console.ResetColor();
        }
    }
}
