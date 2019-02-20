﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_data_structures
{
    class Algorithms
    {
        public static int fib_recursive(int n)
        {
            if ((n == 1) || (n == 2))
                return 1;
            else
                return fib_recursive(n - 1) + fib_recursive(n - 2);
        }

        public static int factorial_recursive(int i)
        {
            if (i < 1)
                return 1;
            else
                return i * factorial_recursive(i - 1);
        }

        public static int factorial_iteratively(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
