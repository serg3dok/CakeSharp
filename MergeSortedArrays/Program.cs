using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = {0, 3, 6, 7, 23, 45, 57, 67};
            int[] arr2 = {2, 4, 6, 7, 8, 12, 23, 34, 46, 56, 68, 789};

            printArray(mergeTwoSortedArrays(arr1, arr2));
            Console.ReadKey();


        }

        public static int[] mergeTwoSortedArrays(int[] arr1, int[] arr2)
        {
            int[] mergedArr  = new int[arr1.Length + arr2.Length];
            int index1 = 0;
            int index2 = 0;
            int mergedIndex = 0;
            while (mergedIndex < mergedArr.Length)
            {
                if (index1 < arr1.Length && index2 < arr2.Length)
                {
                    if (arr1[index1] < arr2[index2])
                    {
                        mergedArr[mergedIndex++] = arr1[index1++];
                    }
                    else
                    {
                        mergedArr[mergedIndex++] = arr2[index2++];
                    }
                } 
                else if (index1 < arr1.Length)
                {
                    mergedArr[mergedIndex++] = arr1[index1++];
                }
                else
                {
                    mergedArr[mergedIndex++] = arr2[index2++];
                }
            }
            return mergedArr;
        }

        public static void printArray(int[] arr)
        {
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
        }

    }
}
