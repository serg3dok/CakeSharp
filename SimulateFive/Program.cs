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
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine(randomFive());
            }
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
