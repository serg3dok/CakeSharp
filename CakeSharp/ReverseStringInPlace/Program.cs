using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStringInPlace
{

    /*
     * Write a function to reverse a string in-place ↴ .
     */

    class Program
    {
        static void Main(string[] args)
        {
            string testData = "Some string to reverse";
            Console.WriteLine(reverseString(testData));
            Console.ReadKey();
        }

        public static string reverseString(string str)
        {
            char[] arrChars = str.ToCharArray();
            for (int i = 0, j = arrChars.Length - 1; i < arrChars.Length / 2; i++, j--)
            {
                char temp = arrChars[i];
                arrChars[i] = arrChars[j];
                arrChars[j] = temp;
            }
            return new string(arrChars);
        }
    }
} // O(N/2)/O(1)
