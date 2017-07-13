using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleRiffleShuffle
{

    /*
     * let's write a function to tell us if a full deck of cards shuffledDeck is a single riffle of two other halves half1 and half2. 
     */

    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> half1 = new Stack<int>();
            Stack<int> half2 = new Stack<int>();
            half1.Push(1);
            half1.Push(2);
            half1.Push(3);
            half1.Push(4);
            half1.Push(5);

            half2.Push(6);
            half2.Push(7);
            half2.Push(8);
            half2.Push(9);
            half2.Push(10);

            Stack<int> shuffledDeck = new Stack<int>();
            shuffledDeck.Push(1);
            shuffledDeck.Push(6);
            shuffledDeck.Push(2);
            shuffledDeck.Push(7);
            shuffledDeck.Push(3);
            shuffledDeck.Push(8);
            shuffledDeck.Push(4);
            shuffledDeck.Push(9);
            shuffledDeck.Push(5);
            shuffledDeck.Push(10);

            Console.WriteLine(isShufled(half1, half2, shuffledDeck));
            Console.ReadKey();

        }

        public static bool isShufled(Stack<int> half1, Stack<int> half2, Stack<int> shuffled)
        {
            while (shuffled.Count > 0)
            {
                if (half2.Pop() != shuffled.Pop())
                {
                    return false;
                }
                if (half1.Pop() != shuffled.Pop())
                {
                    return false;
                }
            }
            return true;

        }
    }
}
