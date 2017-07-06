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
        public Node Next { get; set; }
        public int Data { get; set; }

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
            

            deleteNode(a);
            printLinkedListNodes(a);

            Console.ReadKey();

        }

        public static void deleteNode(Node nodeToDelete)
        {
            if (nodeToDelete.Next != null)
            {
                Node nextNode = nodeToDelete.Next;
                nodeToDelete.Next = nextNode.Next;
                nodeToDelete.Data = nextNode.Data;
            } else
            {
                throw new InvalidOperationException("Can't delete last node with this method");
            }
            
        }

        // O(1)/O(1)

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
