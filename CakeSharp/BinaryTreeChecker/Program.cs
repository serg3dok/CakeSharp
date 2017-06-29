using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = BinaryTree.createValidBinaryTree();

            if (isBinaryTreeValid(tree, true))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            Console.Read();

        }

        private static bool isBinaryTreeValid(BinaryTree tree, bool r)
        {
            var stack = new Stack<BinaryTree>();
            stack.Push(tree);

            /*             
             * Let's use DFS...
             */

            while (stack.Count > 0)
            {
                BinaryTree treeNode = stack.Pop();

                if (treeNode.Left != null)
                {
                    if (treeNode.Left.Value >= treeNode.Value)
                    {
                        return false;
                    }
                    stack.Push(treeNode.Left);
                }

                if (treeNode.Right != null)
                {
                    if (treeNode.Right.Value <= treeNode.Value)
                    {
                        return false;
                    }
                    stack.Push(treeNode.Right);

                }
            }

            return true;
        }
    }
}
