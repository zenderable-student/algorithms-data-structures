using System;
namespace Algorithms_and_data_structures
{
    internal static class Fibonacci
    {
        public static void FibonacciIterativelyMenu()
        {
            ulong n;
            Console.Write("\nType amount of fibonacci numbers: ");
            while (!ulong.TryParse(Console.ReadLine(), out n))
                Console.WriteLine("\nType number: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"n-th number is {Fib_iterative(n)}\n");
            Console.ResetColor();
        }
        private static ulong Fib_iterative(ulong m)
        {
            if (m <= 2)
                return 1;
            else
            {
                ulong f1 = 1;
                ulong f2 = 1;
                ulong temp;
                for (ulong i = 3; i <= m; i++)
                {
                    temp = f1 + f2;
                    f1 = f2;
                    f2 = temp;
                }

                return f2;
            }
        }
        public static void FibonacciRecursivelyMenu()
        {
            ulong m;
            Console.Write("\nType amount of fibonacci numbers: ");
            while (!ulong.TryParse(Console.ReadLine(), out m))
                Console.WriteLine("\nType number: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"n-th number is {Fib_recursive(m)}\n");
            Console.ResetColor();
        }
        private static ulong Fib_recursive(ulong n)
        {
            if ((n == 1) || (n == 2))
                return 1;
            else
                return Fib_recursive(n - 1) + Fib_recursive(n - 2);
        }


    }
}