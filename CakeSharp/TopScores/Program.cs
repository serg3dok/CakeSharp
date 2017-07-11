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
            int[] scores = new int[max+1];
            foreach (var score in unsorted)
            {
                scores[score]++;
            }

            int[] sorted = new int[max];  // 1

            int scoreIndex = max; // score index
            int sortedIndex = 0;

            while (sortedIndex < max) // iterate through sorted from top to bottom  // sortedIndex = 0
            {
                while (scores[scoreIndex] > 0 && sortedIndex < max) // iterate through scores  // scores[100] = 2
                {
                    sorted[sortedIndex++] = scoreIndex; // populate sorted sorted[0] = 100
                    scores[scoreIndex]--;
                }
                scoreIndex--;
            }
            return sorted;
        }  // O(N)/O(N)

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
