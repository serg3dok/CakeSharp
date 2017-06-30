using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillionGazillion
{
    class Program
    {
        static void Main(string[] args)
        {
            Trie trie = new Trie();

            string[] urls =
            {
                "google.com",
                "google.com/maps",
                "google.com/maps/gps",
                "google.com/about",
                "google.com/about/contacts",
                "google.com/about/job"
            };

            string word = "sometext";

            trie = addToTrie(trie, word);

            bool isWordInTrie = checkWordInTrie(trie, word);
            Console.WriteLine(isWordInTrie);
            Console.Read();

        }

        private static Trie addToTrie(Trie trie, string word)
        {
            char endOfWord = '\0';
            Trie currentNode = trie;
            foreach (var c in word)
            {
                if (!currentNode.hasChildNode(c))
                {
                    currentNode.makeNewNode(c);
                }
                currentNode = currentNode.getTrieNode(c);
            }
            if (!currentNode.hasChildNode(endOfWord))
            {
                currentNode.makeNewNode(endOfWord);
            }

            return trie;
        }

        private static bool checkWordInTrie(Trie trie, string word)
        {
            char endOfWord = '\0';
            Trie currentNode = trie;
            bool result = false;
            foreach (var c in word)
            {
                if (currentNode.hasChildNode(c))
                {
                    currentNode = currentNode.getTrieNode(c);
                }
                else
                {
                    return result;
                }
                
            }
            if (currentNode.hasChildNode(endOfWord))
            {
                result = true;
            }

            return result;
        }
    }
}
