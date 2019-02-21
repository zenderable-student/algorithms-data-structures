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
    }
}
