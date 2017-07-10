using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TopScores
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = createTestData(500);
            printScores(sort(data, 100));
            Console.Read();



        }

        public static int[] sort(int[] unsorted, int max) 
        {
            int[] scores = new int[max];
            foreach (var score in unsorted)
            {
                scores[score]++;
            }

            int[] sorted = new int[max];  // 1

            int i = max - 1;
            int j = 100;

            while (i >= 0) // iterate through sorted from top to bottom
            {
                while (scores[j] > 0 && i >= 0) // iterate through unsorted each value
                {
                    sorted[i--] = j;
                    scores[j]--;

                }
                i--;
                j--;
            }
            return sorted;
        }

        public static int[] createTestData(int num)
        {
            int[] unsortedScores = new int[num];

            var rnd = new Random();
            for (int i = 0; i < unsortedScores.Length; i++)
            {
                unsortedScores[i] = rnd.Next(100);

            }

            return unsortedScores;
        }

        public static void printScores(int[] scores)
        {
            foreach (var score in scores)
            {
                Console.WriteLine(score);
            }
        }
    }
}
