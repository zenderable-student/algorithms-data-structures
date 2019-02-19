using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_data_structures
{
    //A simple console app with all algorithms and data structures at my university (UKW)
    class MainMenu
    {
        static void Main(string[] args)
        {
            int first_choice;
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
                //ListOfAlgorithms:
                //list of all algorithms
            }
            else
            {
                //ListOfDataStructures:
                //list of all examples of data structures
            }


            Console.ReadKey();
        }
    }
}
