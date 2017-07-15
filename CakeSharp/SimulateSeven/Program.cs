using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulateSeven
{
    class Program
    {
        public static Random rnd = new Random();
        
        static void Main(string[] args)
        {
            //Console.WriteLine(generateRandomSeven());
            testProbability();
            Console.ReadKey();
        }

        public static int generateRandomSeven()
        {
            

            int[,] matrix =
            {
                {1, 2, 3, 4, 5},
                {6, 7, 1, 2, 3},
                {4, 5, 6, 7, 1},
                {2, 3, 4, 5, 6},
                {7, 0, 0, 0, 0}
            };
            int result = 0;
            while ( result == 0)
            {
                result = matrix[randomFive() - 1, randomFive() - 1];

            } 

            return result;
        }

        public static int randomFive()
        {
            return rnd.Next(1, 6);
        }

        public static void testProbability()
        {
            //test probability
            int a1 = 0, a2 = 0, a3 = 0, a4 = 0, a5 = 0, a6 = 0, a7 = 0;

            for (int i = 0; i < 1000000; i++)
            {
                int n = generateRandomSeven();
                switch (n)
                {
                    case 1:
                        a1++;
                        break;
                    case 2:
                        a2++;
                        break;
                    case 3:
                        a3++;
                        break;
                    case 4:
                        a4++;
                        break;
                    case 5:
                        a5++;
                        break;
                    case 6:
                        a6++;
                        break;
                    case 7:
                        a7++;
                        break;
                }
            }

            Console.WriteLine("1 " + a1);
            Console.WriteLine("2 " + a2);
            Console.WriteLine("3 " + a3);
            Console.WriteLine("4 " + a4);
            Console.WriteLine("5 " + a5);
            Console.WriteLine("6 " + a6);
            Console.WriteLine("7 " + a7);

        }
    }
}
