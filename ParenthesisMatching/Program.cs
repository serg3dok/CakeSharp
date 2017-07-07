using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParenthesisMatching
{
    class Program
    {

        static void Main(string[] args)
        {
            string testString =
                "Sometimes (when I nest them (my parentheticals) too much (like this (and this))) they get confusing.";

            Console.WriteLine(findMatchingParenthesis2(testString, 10));
            Console.ReadKey();

        }

        public static int findMatchingParenthesis(string str, int first)
        {
            char[] arrChars = str.ToCharArray();
            Stack<char> stackOfParenthesis = new Stack<char>();
            stackOfParenthesis.Push(arrChars[first]);
            int i = first;
            while (stackOfParenthesis.Count != 0)
            {
                i++;
                if (arrChars[i] == '(')
                {
                    stackOfParenthesis.Push('(');
                }
                if (arrChars[i] == ')')
                {
                    stackOfParenthesis.Pop();
                }
            }

            return i;
        } // O(N)/O(N/2) 


        public static int findMatchingParenthesis2(string str, int first)
        {
            int parenthesisCounter = 1;
            
            for (int position = first+1; position < str.Length; position++)
            {
                
                if (str[position] == '(')
                {
                    parenthesisCounter++;
                }
                if (str[position] == ')')
                {
                    parenthesisCounter--;
                }
                if (parenthesisCounter == 0)
                {
                    return position;
                }

            }

            return -1;
        } // O(N)/O(1)
    }
}

