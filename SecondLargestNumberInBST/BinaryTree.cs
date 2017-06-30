using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLargestNumberInBST
{
    class BinaryTree
    {
        public int Value;
        public BinaryTree Left;
        public BinaryTree Right;


        public BinaryTree(int value)
        {
            Value = value;
        }

        public static BinaryTree CreateBinaryTree()
        {
            BinaryTree tree = new BinaryTree(50);

            // left side
            tree.Left = new BinaryTree(25);
            tree.Left.Left = new BinaryTree(10);
            tree.Left.Right = new BinaryTree(35);
            tree.Left.Right.Right = new BinaryTree(40);

            // right side
            tree.Right = new BinaryTree(75);
            tree.Right.Left = new BinaryTree(60);
            tree.Right.Right = new BinaryTree(85);
            tree.Right.Right.Right = new BinaryTree(100);
            tree.Right.Right.Right.Left = new BinaryTree(90);
            tree.Right.Right.Right.Right = new BinaryTree(110);



            return tree;
        }

        public static BinaryTree CreateLeftBinaryTree()
        {
            BinaryTree tree = new BinaryTree(50);

            // left side
            tree.Left = new BinaryTree(25);
            tree.Left.Left = new BinaryTree(10);
            tree.Left.Right = new BinaryTree(35);
            tree.Left.Right.Right = new BinaryTree(40);





            return tree;
        }

    }
}
