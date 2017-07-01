using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindRotationPoint
{
    class Program
    {

        /*
         * Write a function for finding the index of the "rotation point," 
         * which is where I started working from the beginning of the dictionary. 
         * This array is huge (there are lots of words I don't know) so we want to be efficient here. 
         */

        static void Main(string[] args)
        {
            char[] charArr = {'k', 'v', 'z', 'a', 'b', 'c', 'd', 'e', 'g', 'i'};

            Console.WriteLine(rotationPointAtIndex(charArr));
            Console.Read();
        }

        public static int rotationPointAtIndex(char[] charArr)
        {
            int startIndex = 0;
            int endIndex = charArr.Length-1;
            int index = 0;

            while (true)
            {

                int distance = endIndex - startIndex;
                int halfDistance = distance / 2;
                int guessIndex = startIndex + halfDistance;
                char guessValue = charArr[guessIndex];

                if (charArr[startIndex] > guessValue)
                {
                    endIndex = guessIndex;
                }
                if (charArr[startIndex] < guessValue)
                {
                    startIndex = guessIndex;
                }
                index = guessIndex;
                if (startIndex + 1 == endIndex)
                {
                    break;
                }
            }

            return index;

        }

    }


}

// O(logN) / O(1)
