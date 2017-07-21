using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindRepeatSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testData = {1, 2, 3, 4, 0, 5, 2, 8, 9};
            Console.WriteLine(findDuplicate(testData));
            Console.Read();
            IList<IList<int>> lst = new List<IList<int>>();
            lst[0].Add(1);
            
        }

        public static int findDuplicate(int[] arr)
        {
            // add all numbers in set O(N), while adding check for duplicate in set, overall O(N)
            ISet<int> set = new HashSet<int>();
            foreach (var i in arr)
            {
                if (set.Contains(i))
                {
                    return i;
                }
                set.Add(i);
            }
            return -1;
        } // O(N)/O(N)
    }
}
