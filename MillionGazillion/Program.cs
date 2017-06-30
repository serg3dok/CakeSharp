using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillionGazillion
{

    /*
     *  I wrote a crawler that visits web pages, 
     *  stores a few keywords in a database, and follows links to other web pages. 
     *  I noticed that my crawler was wasting a lot of time visiting the same pages over and over, 
     *  so I made a hash set, visited, where I'm storing URLs I've already visited. 
     *  Now the crawler only visits a URL if it hasn't already been visited.
     *  Thing is, the crawler is running on my old desktop computer in my parents' basement (where I totally don't live anymore), 
     *  and it keeps running out of memory because visited is getting so huge.
     *  How can I trim down the amount of space taken up by visited? 
     */

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

            string word = "google.com/maps/gps";

            //trie = addToTrie(trie, word);

            foreach (var url in urls)
            {
                trie = addToTrie(trie, url);
            }

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
