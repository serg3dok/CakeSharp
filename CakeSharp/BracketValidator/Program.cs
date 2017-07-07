using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BracketValidator
{


    /* 29 Bracket Validator
     * Write an efficient function that tells us whether or not an input string's 
     * openers and closers are properly nested. 
     */


    class Program
    {
        static void Main(string[] args)
        {
            string code1 = "{asda [ fdf12]23 (fdsf ) dfsfss}sfs"; // true
            string code2 = "asda{ asda[ asd(as ]s )3 }sda"; // false
            string code3 = "asa{ a[ }asa"; // false

            Console.WriteLine(validateBrackets(code1));
            Console.ReadKey();

        }

        public static bool validateBrackets(string str)
        {
            Stack<char> stack = new Stack<char>();
            char[] arrChar = str.ToCharArray();

            foreach (var c in arrChar)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                if (c == ')')
                {
                    if (stack.Pop() != '(')
                    {
                        return false;
                    }
                }
                if (c == '}')
                {
                    if (stack.Pop() != '{')
                    {
                        return false;
                    }
                }
                if (c == ']')
                {
                    if (stack.Pop() != '[')
                    {
                        return false;
                    }
                }

            }
            return true;
        } // O(N)/O(N/2)
    }
}
