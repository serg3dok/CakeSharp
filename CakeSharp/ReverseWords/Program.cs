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

        }

        public static string ReverseWords(string str)
        {
            char[] charArr = str.ToCharArray();



            return new string(charArr);
        }
    }
}
