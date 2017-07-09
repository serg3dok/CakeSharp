using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveStringPermutations
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "test";
            printSet(getAllPermutations(testString));
            Console.Read();

        }

        public static ISet<string> getAllPermutations(string str)
        {
            if (str.Length <= 1)
            {
                return new HashSet<string>(str.Select(c => new string(c, 1)));
            }

            
            string strExceptLastChar = str.Substring(0, str.Length - 1);
            char lastChar = str[str.Length - 1];
            var allPermutationsExceptLast = getAllPermutations(strExceptLastChar);
            //-----------------------
            var allPermutations = new HashSet<string>();
            foreach (var permutationExceptLast in allPermutationsExceptLast)
            {
                for (int i = 0; i < permutationExceptLast.Length; i++)
                {
                    allPermutations.Add(permutationExceptLast.Substring(0, i) +
                                        lastChar +
                                        permutationExceptLast.Substring(i));
                }
            }
            return allPermutations;

        }

        public static void printSet(ISet<string> setToPrint)
        {
            foreach (var str in setToPrint)
            {
                Console.WriteLine(str);
            }
        }
    }
}
