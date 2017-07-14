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

            int[] halfOne = { 1, 2, 3 };
            int[] halfTwo = { 4, 5, 6};
            int[] shuffledCards = { 6, 3, 5, 2, 4, 1 };




            Console.WriteLine(isShuffled2(halfOne, halfTwo, shuffledCards));
            Console.ReadKey();

        }

        public static bool isShuffled2(int[] half1, int[] half2, int[] shuffledDeck)
        {

            if (shuffledDeck.Length == 0)
            {
                return false;
            }
             
            while (shuffledDeck.Length > 0 && half1.Length > 0 && half2.Length > 0)
            {

                if (half1.Length == half2.Length)
                {
                    if (shuffledDeck[0] == half1[half1.Length - 1])
                    {
                        half1 = removeLastCard(half1);
                    }

                    if (shuffledDeck[0] == half2[half2.Length - 1])
                    {
                        half2 = removeLastCard(half2);
                    }
                    shuffledDeck = removeTopCard(shuffledDeck);
                }

                if (half1.Length > half2.Length)
                {
                    if (shuffledDeck[0] != half1[half1.Length - 1])
                    {
                        return false;
                    }

                    half1 = removeLastCard(half1);
                }

                if (half1.Length < half2.Length)
                {
                    if (shuffledDeck[0] != half2[half2.Length - 1])
                    {
                        return false;
                    }

                    half2 = removeLastCard(half2);

                }

                shuffledDeck = removeTopCard(shuffledDeck);
            }

            if (shuffledDeck.Length == 0 && half1.Length == 0 && half2.Length == 0)
            {
                return true;
            }

            return false;
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

        public static int[] removeTopCard(int[] source)
        {
            int[] result = new int[source.Length - 1];
            Array.Copy(source, 1, result, 0, result.Length);
            return result;
        }

        public static int[] removeLastCard(int[] source)
        {
            int[] result = new int[source.Length - 1];
            Array.Copy(source, result, result.Length);
            return result;
        }
    }

    
}
