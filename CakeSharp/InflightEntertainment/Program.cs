using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InflightEntertainment
{
    class Program
    {

        /*
         * Write a function that takes an integer flightLength (in minutes) 
         * and an array of integers movieLengths (in minutes) 
         * and returns a boolean indicating whether there are two numbers 
         * in movieLengths whose sum equals flightLength.
         */
          
        static void Main(string[] args)
        {
            int[] movies = {180, 140, 134, 90, 105, 115};
            Console.WriteLine(isThereTwoMovies(movies, 195));
            Console.Read();
        }

        public static bool isThereTwoMovies(int[] movies, int flight)
        {
            var moviesSoFar = new List<int>();
            foreach (var movie in movies)
            {
                if (moviesSoFar.Contains(flight - movie))
                {
                    return true;
                }
                moviesSoFar.Add(movie);
            }

            return false;
        }
    }
}

// O(N)/O(N)
