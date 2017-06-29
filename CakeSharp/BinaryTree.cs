using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeSharp
{
    public class BinaryTree
    {
        public BinaryTree node;
        public BinaryTree left;
        public BinaryTree right;
        public int value;
        //public int depth;

        #region Constructor
        public BinaryTree() { }


        public BinaryTree(int value)
        {
            this.value = value;
        }



        #endregion

        public static BinaryTree CreateTree()
        {
            BinaryTree tree = new BinaryTree(5);
            // left
            tree.left = new BinaryTree(3);
            tree.left.left = new BinaryTree(2);
            tree.left.right = new BinaryTree(3);
            tree.left.right.right = new BinaryTree(4);
            tree.left.left.left = new BinaryTree(2);
            //right
            tree.right = new BinaryTree(10);
            tree.right.left = new BinaryTree(7);
            tree.right.left.left = new BinaryTree(6);
            tree.right.right = new BinaryTree(11);
            tree.right.right.right = new BinaryTree(12);
            tree.right.right.right.left = new BinaryTree(15);


            return tree;
        }
    }
}
