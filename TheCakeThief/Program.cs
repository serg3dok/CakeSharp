using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCakeThief
{
    class CakeTypeAndDiff
    {
        public CakeType Type;
        public int Diff;

        public CakeTypeAndDiff(CakeType type, int diff)
        {
            Type = type;
            Diff = diff;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CakeType[] cakeTypes = new [] {new CakeType(7, 160), new CakeType(3, 90), new CakeType(2, 15) };
            int capacity = 20;

            Console.WriteLine(getTheBestValue(cakeTypes, capacity));
            Console.Read();
            
        }

        public static int getTheBestValue(CakeType[] cakeTypes, int capacity)
        {
            int maxDiff = 0;
            int maxDiffIndex = 0;
            for (int i = 0; i < cakeTypes.Length; i++) 
            {
                if (cakeTypes[i].Value / cakeTypes[i].Weight > maxDiff)
                {
                    maxDiffIndex = i;
                }
            }

            int fitsInBag = capacity / cakeTypes[maxDiffIndex].Weight;
            return fitsInBag * cakeTypes[maxDiffIndex].Value;


        }


        public static CakeTypeAndDiff[] sortCakesByDiff(CakeType[] cakeTypes, int capacity)
        {
            var cakeTypesAndDiffs = new CakeTypeAndDiff[cakeTypes.Length];
            int max = 0;
            int maxIndex = 0;
            var diff = new int[cakeTypes.Length];




            for (int i = 0; i < cakeTypes.Length; i++)
            {
                diff[i] = cakeTypes[i].Value / cakeTypes[i].Weight;
            }

            Array.Sort(diff);



            return null;
        }
    }
}
