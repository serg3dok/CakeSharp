using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeChecker
{
    class BinaryTree
    {
        private int Value;
        private BinaryTree Left;
        private BinaryTree Right;

        BinaryTree() { }

        BinaryTree(int value)
        {
            Value = value;
        }

        public BinaryTree createBinaryTree()
        {
            BinaryTree tree = new BinaryTree(50);
            // left
            tree.Left = new BinaryTree(25);

            tree.Left.Left = new BinaryTree(10);
            tree.Left.Right = new BinaryTree(35);

            tree.Left.Left.Right = new BinaryTree(15);
            tree.Left.Right.Right = new BinaryTree(40);

            // right
            tree.Right = new BinaryTree(75);

            tree.Right.Left = new BinaryTree(65);
            tree.Right.Right = new BinaryTree(85);

            tree.Right.Right.Left = new BinaryTree(80);
            tree.Right.Right.Right = new BinaryTree(90);


            return tree;
        }

    }
}
