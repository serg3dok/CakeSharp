using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InPlaceShuffle
{
    class Program
    {

       

        static void Main(string[] args)
        {
            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            printArray(shuffleArray(arr));
            Console.ReadKey();
        }

        public static int[] shuffleArray(int[] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                int randomIndex = rnd.Next(arr.Length - 1);
                int tmp = arr[randomIndex];
                arr[randomIndex] = arr[i];
                arr[i] = tmp;
            }

            return arr;
        }

        public static void printArray(int[] arr)
        {
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
