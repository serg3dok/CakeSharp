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

            Console.WriteLine(palindromeChecker3(test5));
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
        } // O(nlogN)/O(N)

        public static bool palindromeChecker2(string str)
        {
            // use 255 array for each character in extended ASCII table
            int[] charCounter = new int[255];
            char[] arrChar = str.ToCharArray();

            foreach (var c in arrChar)
            {
                charCounter[c]++;
            }

            int odd = 0;
            foreach (var n in charCounter)
            {
                if (n % 2 == 1)
                {
                    odd++;
                }
                if (odd > 1)
                {
                    return false;
                }
            }
            
            return true;
        } // O(N)/O(N)

        public static bool palindromeChecker3(string str)
        {
            char[] arrChars = str.ToCharArray();
            var noPair = new HashSet<char>();

            foreach (var c in arrChars)
            {
                if (noPair.Contains(c))
                {
                    noPair.Remove(c);
                }
                else
                {
                    noPair.Add(c);
                }
            }
            return noPair.Count <= 1;
        }  // O(N)/O(N)

    }
    
}
