namespace Algorithms_and_data_structures
{
    class Fibonacci
    {
        public static ulong Fib_recursive(ulong n)
        {
            if ((n == 1) || (n == 2))
                return 1;
            else
                return Fib_recursive(n - 1) + Fib_recursive(n - 2);
        }

        public static ulong Fib_iteratively(ulong m)
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
    }
}