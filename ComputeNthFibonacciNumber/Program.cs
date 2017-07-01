using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputeNthFibonacciNumber
{
    class Program
    {

        /*
         * Write a function Fib() that a takes an integer n and returns the nth fibonacci ↴ number. 
         */

        static void Main(string[] args)
        {
            int fibNumber = 12;
            int nthFib = 0;
            Console.WriteLine(Fib(fibNumber, nthFib));
            Console.Read();
        }

        public static int Fib(int n, int nthFib)
        {
            if (n == 0 || n == 1)
            {
                return nthFib;
            }
            return Fib(n-1, nthFib++)+Fib(n-2, nthFib);

        }

    }
}
