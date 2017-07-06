using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStolenBreakfastDrone
{

    /*
     * Given the array of IDs, 
     * which contains many duplicate integers and one unique integer, 
     * find the unique integer.
     */

    class Program
    {
        static void Main(string[] args)
        {
            int[] id = {123123500, 123123500, 091165890, 091165890,
                197987500, 197987500, 008456789, 170952377,
                170952377, 097111588, 097111588, 097111588,
                789225897, 789225897, 422246625, 422246625};
            Console.WriteLine(findUnicNumber(id));
            Console.Read();

        }

        public static int findUnicNumber(int[] idArr)
        {
            Array.Sort(idArr);

            for (int i = 0; i < idArr.Length - 1; i++)
            {
                if (idArr[i] != idArr[i + 1])
                {
                    return idArr[i];
                }
            }
            return idArr[idArr.Length - 1];

        }
        // O(nlogn)/O(1)
    }
}
