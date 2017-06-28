using CakeSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeSharp
{

    /*
        Write a function to see if a binary tree ↴ is "superbalanced" (a new tree property we just made up).
        A tree is "superbalanced" if the difference between the depths of any two leaf nodes ↴ is no greater than one. 
    */

    public class BinaryTree
    {
        public BinaryTree left;
        public BinaryTree right;
        private int value;
        private int depth;

        #region Constructor
        public BinaryTree(){}

        public BinaryTree(int value)
        {
            this.value = value;
        }


        #endregion
    }

    class Program
    {

        public static BinaryTree CreateTree()
        {
            BinaryTree tree = new BinaryTree(5);
            // left
            tree.left = new BinaryTree(3);
            tree.left.left = new BinaryTree(2);
            tree.left.right = new BinaryTree(3);
            tree.left.right.right = new BinaryTree(4);
            //right
            tree.right = new BinaryTree(10);
            tree.right.left = new BinaryTree(7);
            tree.right.left.left = new BinaryTree(6);
            tree.right.right = new BinaryTree(11);
            tree.right.right.right = new BinaryTree(12);


            return tree;
        }



        static void Main(string[] args)
        {
            BinaryTree tree = CreateTree();
            if (isTreeBalanced(tree))
            {
                
            }
        }


        public static bool isTreeBalanced(BinaryTree tree)
        {
            /* 
             * Let's use depth first search algorithm to get faster to the leafs,
             * track depth and compare with depths what we saw so far             
             */

            Stack<BinaryTree> stack = new Stack<BinaryTree>();

            stack.Push(tree);
            HashSet<int> depth = new HashSet<int>();
            

            while (stack.Count > 0)
            {
                BinaryTree node = stack.Pop();

            }

            return false;
        }

        
    }
}
