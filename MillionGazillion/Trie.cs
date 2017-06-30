using System.Collections.Generic;

namespace MillionGazillion
{
    public class Trie
    {
        Dictionary<char, Trie> TrieNode = new Dictionary<char, Trie>();

        public bool hasChildNode(char c)
        {
            return TrieNode.ContainsKey(c);
        }

        public void makeNewNode(char c)
        {
            TrieNode[c] = new Trie();
        }

        public Trie getTrieNode(char c)
        {
            return TrieNode[c];
        }


    }
}