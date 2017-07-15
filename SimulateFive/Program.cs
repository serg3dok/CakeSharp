using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulateFive
{
    class Program
    {
        public static Random rnd = new Random();

        static void Main(string[] args)
        {

            /* test probability
            int a1 = 0, a2 = 0, a3 = 0, a4 = 0, a5 = 0;
            
            for (int i = 0; i < 1000000; i++)
            {
                int n = randomFive();
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
                }
            }

            Console.WriteLine("1 " + a1);
            Console.WriteLine("2 " + a2);
            Console.WriteLine("3 " + a3);
            Console.WriteLine("4 " + a4);
            Console.WriteLine("5 " + a5);
            */

            Console.WriteLine(randomFive());
            Console.ReadKey();
        }

        public static int randomFive()
        {
            int n = 7;
            while (n > 5)
            {
                n = randomSeven();
            }

            return n;
        }

        public static int randomSeven()
        {
            return rnd.Next(1, 8);
        }
    }
}
