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
         * Write a function Fib() that a takes an integer n and returns the nth fibonacci number. 
         */

        static void Main(string[] args)
        {
            int fibNumber = 12;
            Console.WriteLine(Fib(fibNumber));
            Console.Read();
        }

        public static int Fib(int fiboNuber)
        {

            int prevPrev = 0;
            int prev = 1;
            int current = 0;

            for (int i = 0; i < fiboNuber; i++)
            {
                current = prevPrev + prev;
                prevPrev = prev;
                prev = current;
            }


            return current;

        }

    }
}

// O(N) O(1)

