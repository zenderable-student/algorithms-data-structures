namespace Algorithms_and_data_structures
{
    class Factorial
    {
        public static ulong Factorial_recursive(ulong i)
        {
            if (i < 1)
                return 1;
            else
                return i * Factorial_recursive(i - 1);
        }
        public static ulong Factorial_iterative(ulong n)
        {
            ulong result = 1;
            for (ulong i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
