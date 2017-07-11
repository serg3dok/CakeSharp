using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhichAppearsTwice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {0, 2, 3, 15, 25, 64, 7, 88, 1, 3, 16, 99};
            Console.WriteLine(findTwice(numbers));
            Console.Read();
        }

        public static int findTwice(int[] nums)
        {
            var map = new Dictionary<int, bool>();
            for (int i = 0; i < nums.Length; i++)
            {
                bool b;
                map.TryGetValue(nums[i], out b);
                if (b)
                {
                    return nums[i];
                } 
                map.Add(nums[i], true);
            }

            return -1;
        }
    }
}


