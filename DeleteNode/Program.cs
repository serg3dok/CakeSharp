using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteNode
{

    class Node
    {
        public Node Next;
        public int Data;

        public Node(int data)
        {
            Data = data;
        }
    }

    class Program
    {

        /*
         * Delete a node from a singly-linked list ↴ , given only a variable pointing to that node.
         */



        

        static void Main(string[] args)
        {

            Node a = new Node(1);
            Node b = new Node(2);
            Node c = new Node(3);
            Node d = new Node(4);

            a.Next = b;
            b.Next = c;
            c.Next = d;
            



            b = deleteNode(b);
            printLinkedListNodes(a);
            Console.ReadKey();

        }

        public static Node deleteNode(Node nodeToDelete)
        {
            nodeToDelete = nodeToDelete.Next;
            return nodeToDelete;
        }

        public static void printLinkedListNodes(Node head)
        {
            while (head != null)
            {
                Console.WriteLine(head.Data);
                head = head.Next;
            }
        }
    }
}
