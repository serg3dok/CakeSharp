using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLargestNumberInBST
{
    class Program
    {

        /*
         * Write a function to find the 2nd largest element in a binary search tree
         * */

        static void Main(string[] args)
        {
            

            BinaryTree tree = BinaryTree.CreateBinaryTree();


            Console.WriteLine(secondNumber(tree));
            Console.Read();
            
        }

        public static int secondNumber(BinaryTree tree)
        {

            // second largest element should be located on right branch before last one
            // so we can go down on right branches and keep in mind previous value
            // if no right branch from root, so return value from root.left

            if (tree.Right == null)
            {
                if (tree.Left != null)
                {
                    return tree.Left.Value;
                }
                throw new ArgumentException();
            }

            int result = tree.Value;
            while (tree.Right != null)
            {
                result = tree.Value;
                tree = tree.Right;
            }
            return result;
        }


    }
}
