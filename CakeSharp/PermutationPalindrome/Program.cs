using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationPalindrome
{

    /*
     * Write an efficient function that checks whether any permutation ↴ 
     * of an input string is a palindrome ↴ . 
     */
    class Program
    {
        static void Main(string[] args)
        {
            string test1 = "civic"; // true
            string test2 = "ivicc"; // true
            string test3 = "civil"; // false
            string test4 = "livci"; // false
            string test5 = "qwertyuioplkjhgfdsazxcvbnmnbvcxzasdfghjklpoiuytrewq"; // true

            Console.WriteLine(palindromeChecker(test5));
            Console.Read();

        }

        public static bool palindromeChecker(string str)
        {
            // sorting array is logn + iteration on sorted array is n = nlogn
            int potentialMiddle = 0;

            char[] arrChars = str.ToCharArray();
            Array.Sort(arrChars); 
            
            for (int i = 0; i < arrChars.Length - 1; i += 2)
            {
                if (arrChars[i] != arrChars[i + 1])
                {
                    potentialMiddle++;
                    i--;
                    if (potentialMiddle > 1)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
