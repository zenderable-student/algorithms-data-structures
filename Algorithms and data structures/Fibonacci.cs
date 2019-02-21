using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_data_structures
{
    class Fibonacci
    {
        public static int fib_recursive(int n)
        {
            if ((n == 1) || (n == 2))
                return 1;
            else
                return fib_recursive(n - 1) + fib_recursive(n - 2);
        }

        public static int fib_iteratively(int m)
        {
            if (m <= 2)
                return 1;
            else
            {
                int f1 = 1;
                int f2 = 1;
                int temp;
                for (int i = 3; i <= m; i++)
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