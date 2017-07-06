using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLinkedList
{

    /*
     * Write a function for reversing a linked list ↴ .
     */

    class Node
    {
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
            // test data
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

            a = reverseLinkedList(a);
            printLinkedList(a);
            Console.ReadKey();

        }

        public static Node reverseLinkedList(Node head)
        {
            
            Node current = head;
            Node prev = null;
            Node next = null;


            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;

            }

            return prev;
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

// O(N) / O(1)
