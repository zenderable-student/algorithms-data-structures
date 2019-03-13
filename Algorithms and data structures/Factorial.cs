using System;
namespace Algorithms_and_data_structures
{
    internal static class Factorial
    {
        public static void FactorialIterativelyMenu()
        {
            ulong factorialNumber;
            Console.Write("\nType number: ");
            while (!ulong.TryParse(Console.ReadLine(), out factorialNumber))
                Console.Write("Wrong! Try again type number: ");
            Console.Write($"Factorial number is {Factorial_iterative(factorialNumber)}\n");
        }
        private static ulong Factorial_iterative(ulong n)
        {
            ulong result = 1;
            for (ulong i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
        public static void FactorialRecursivelyMenu()
        {
            ulong factorialNumber;
            Console.Write("\nType number: ");
            while (!ulong.TryParse(Console.ReadLine(), out factorialNumber))
                Console.Write("Wrong! Try again type number: ");
            Console.Write($"Factorial number is {Factorial_recursive(factorialNumber)}\n");
        }

        private static ulong Factorial_recursive(ulong i)
        {
            if (i < 1)
                return 1;
            else
                return i * Factorial_recursive(i - 1);
        }

    }
}
