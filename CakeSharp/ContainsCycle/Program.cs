using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainsCycle
{

    /*
     * You have a singly-linked list ↴ and want to check if it contains a cycle. 
     */

    class Node
    {
        public Node Next { get; set; }
        public int Value { get; set; }

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
            Node k = new Node(9);
            a.Next = b;
            b.Next = c;
            c.Next = d;
            d.Next = e;
            e.Next = f;
            f.Next = g;
            g.Next = h;
            h.Next = k;
            k.Next = c;

            Console.WriteLine(containsCycle(a));
            Console.ReadKey();

        }

        public static bool containsCycle(Node head)
        {
            Node slow = head;
            Node fast = head;

            while (fast != null && fast.Next != null)
            {
                fast = fast.Next.Next;
                slow = slow.Next;

                if (fast == slow)
                {
                    return true;
                }
                
            }
            return false;
        }
    }
}

// O(n)/ O(1)
