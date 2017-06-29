using CakeSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeSharp
{

    /*
        Write a function to see if a binary tree ↴ is "superbalanced" (a new tree property we just made up).
        A tree is "superbalanced" if the difference between the depths of any two leaf nodes ↴ is no greater than one. 
    */

    public class Node
    {
        public BinaryTree TreeNode;
        public int Depth;

        public Node(BinaryTree treeNode, int depth)
        {
            TreeNode = treeNode;
            Depth = depth;
        }
    }


    class Program
    {

        static void Main(string[] args)
        {
            BinaryTree tree = BinaryTree.CreateTree();
            if (isTreeBalanced(tree))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.ReadLine();
        }


        public static bool isTreeBalanced(BinaryTree tree)
        {
            /* 
             * Let's use depth first search algorithm to get faster to the leafs,
             * track depth and compare with depths what we saw so far             
             */

            if (tree == null)
            {
                return true;
            }

            Stack<Node> stack = new Stack<Node>();


            stack.Push(new Node(tree, 0));

            //Collection<int> depths = new Collection<int>();
            var depth = new List<int>(3);
            

            while (stack.Count > 0)
            {
                Node node = stack.Pop();
                int d = node.Depth;
                BinaryTree treeNode = node.TreeNode;

                if (treeNode.left == null && treeNode.right == null)
                {

                    // leaf case
                    //Console.WriteLine("Leaf d: " + d);
                    if (!depth.Contains(d))
                    { //
                        depth.Add(d);
                        if (depth.Count > 2 || depth.Count == 2 && Math.Abs(depth[0] - depth[1]) > 1)
                        {
                            return false;
                        }
                    }

                }
                else // not leaf case, go deeper
                {
                    if (treeNode.left != null)
                    {
                        stack.Push(new Node(treeNode.left, d+1));
                    }
                    if (treeNode.right != null)
                    {
                        stack.Push(new Node(treeNode.right, d+1));
                    }
                }

            }

            return true;
        }
    }
}
