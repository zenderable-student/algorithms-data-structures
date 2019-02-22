using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_data_structures
{
    class Fibonacci
    {
        public static ulong fib_recursive(ulong n)
        {
            if ((n == 1) || (n == 2))
                return 1;
            else
                return fib_recursive(n - 1) + fib_recursive(n - 2);
        }

        public static ulong fib_iteratively(ulong m)
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