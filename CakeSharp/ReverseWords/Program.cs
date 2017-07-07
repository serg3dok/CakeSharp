using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWords
{

 /*
 * Write a function ReverseWords() 
 * that takes a string message 
 * and reverses the order of the words in-place ↴ .
 */
    class Program
    {
        static void Main(string[] args)
        {
            string message = "message coded test a is This";
            //                ^                          ^
            //                sihT si a tset
            //                   ^

            Console.WriteLine(ReverseWords(message));
            Console.ReadKey();

        }

        public static string ReverseWords(string str)
        {
            char[] charArr = str.ToCharArray();
            int startIndex = 0;
            int endIndex = charArr.Length - 1;

            while (startIndex < endIndex)
            {
                char tmp = charArr[endIndex];
                charArr[endIndex] = charArr[startIndex];
                charArr[startIndex] = tmp;
                startIndex++;
                endIndex--;
            } 
            
            for (int i = 0; i < charArr.Length; i++)
            {
                startIndex = i;
                endIndex = i;
                while (charArr[endIndex] != ' ')
                {
                    if (endIndex + 1 == charArr.Length)
                    {
                        break;
                    }
                    endIndex++;
                    i = endIndex;
                }

                if (charArr[endIndex] == ' ')
                {
                    endIndex--;
                }

                while (startIndex < endIndex)
                {
                    char tmp = charArr[endIndex];
                    charArr[endIndex] = charArr[startIndex];
                    charArr[startIndex] = tmp;
                    startIndex++;
                    endIndex--;
                }
            }
            
            return new string(charArr);
        }
    }
}
