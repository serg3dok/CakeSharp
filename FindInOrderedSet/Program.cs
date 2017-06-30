using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FindInOrderedSet
{
    class Program
    { 
        /*
         * Suppose we had an array of nnn integers sorted in ascending order. 
         * How quickly could we check if a given integer is in the array?
         */

        static void Main(string[] args)
        {
            // we can use binary search aproach
            // divide by 2 recurivelly until find given number

            int[] numbers = {1, 2, 5, 7, 9, 12, 15};
            Console.WriteLine(CheckIfArrayContainsNumber(numbers, 15));
            Console.Read();

        }

        public static bool CheckIfArrayContainsNumber(int[] arrOfNumbers, int target)
        {

            int startIndex = -1;
            int endIndex = arrOfNumbers.Length;

            while (startIndex + 1 < endIndex)
            {
                int distance = endIndex - startIndex;
                int halfDistance = distance / 2;
                int guessIndex = startIndex + halfDistance;
                int guessValue = arrOfNumbers[guessIndex];
                if (guessValue == target)
                {
                    return true;
                }
                if (target < guessValue)
                {
                    endIndex = guessIndex;
                }
                if (target > guessValue) 
                {
                    startIndex = guessIndex;
                }
            }
            return false;
        }
    }
}

// Binary search
// O(logN)/O(1)
