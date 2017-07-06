using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KthToLastNodeNodeInLinkedList
{

    /*
     * You have a linked list ↴ and want to find the kkkth to last node. 
     */


    public class Node {
        public Node Next { get; set;  }
        public int Value { get; set;  }

        public Node(int value)
        {
            Value = value;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Node a = new Node(1);
            Node b = new Node(2);
            Node c = new Node(3);
            Node d = new Node(4);
            Node e = new Node(5);
            Node f = new Node(6);
            Node g = new Node(7);
            Node h = new Node(8);

            a.Next = b;
            b.Next = c;
            c.Next = d;
            d.Next = e;
            e.Next = f;
            f.Next = g;
            g.Next = h;

            Node kthNode = kthToLastNode(1, a);
            Console.WriteLine(kthNode.Value);
            Console.Read();


        }


        public static Node kthToLastNode(int kth, Node head) 
        {
            Queue<Node> queue = new Queue<Node>();
            Node result = null;
            while (head != null)
            {
                queue.Enqueue(head);
                head = head.Next;
                if (queue.Count == kth)
                {
                    result = queue.Dequeue();
                }
            }

            return result;
        }

        public static void printLinkedList(Node head)
        {
            while (head != null)
            {
                Console.WriteLine(head.Value);
                head = head.Next;
            }
        }
    }
}
