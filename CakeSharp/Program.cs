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
        private Node node;


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

            Stack<BinaryTree> stack = new Stack<BinaryTree>();


            stack.Push(tree);

            Collection<int> depths = new Collection<int>();

            depths[0] = -1;
            depths[1] = -1;
            depths[2] = -1;

            while (stack.Count > 0)
            {
                BinaryTree node = stack.Pop();


                if (tree.left == null && tree.right == null)
                {
                }
                else
                {
                    if (tree.left != null)
                    {
                        stack.Push(tree.left);
                    }
                    if (tree.right != null)
                    {
                        stack.Push(tree.right);
                    }
                    
            }

            return false;
        }
    }
}
