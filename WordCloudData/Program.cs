using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCloudData
{
    class Program
    {
        static void Main(string[] args)
        {
            string testData = "The biggest problems I see in industry code reviews are code complexity, real time performance, code quality, weak development process, and dependability gaps. Here's an index into blog postings and other sources that explains the problems and how to deal with them. Several times a year I fly or drive(or webex) to visit an embedded system design team and give them some feedback on their embedded software. I've done this perhaps 175 times so far (and counting). Every project is different and I ask different questions every time. But the following are the top five areas I've found that need attention in the past few years. pointers will send you to my previous blog postings on these topics.";
            string myTestData = "   something, that we can play with";
            printDic(wordsToDict(testData));
            Console.Read();

        }

        public static Dictionary<string, int> wordsToDict(string str)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            for (int i = 0; i < str.Length; i++)
            {
                string word = "";
                while (isLetter(str[i]))
                {
                    char c = char.ToLower(str[i]);
                    word = word + c;
                    if (i == str.Length - 1)
                    {
                        break;
                    }
                    i++;

                }

                if (word == "")
                {
                    continue;
                }

                if (dict.ContainsKey(word))
                {
                    dict[word] += 1;
                }
                else
                {
                    dict.Add(word, 1);
                }
                
            }

            return dict;
        }

        public static bool isLetter(char c)
        {
            if (c > 64 && c < 123)
            {
                return true;
            }
            return false;
        }

        public static void printDic(Dictionary<string, int> dict)
        {
            foreach (var i in dict)
            {
                Console.WriteLine(i.Key + " - " + i.Value);
            }
        }

    }
}
// O(N)/O(N)
