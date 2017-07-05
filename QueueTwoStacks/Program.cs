using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace QueueTwoStacks
{

    /*
     * mplement a queue ↴ with 2 stacks ↴ . 
     * Your queue should have an enqueue and a dequeue 
     * function and it should be "first in first out" (FIFO). 
     */

     // 2 3
     // 1



    class Program
    {

        class MyQueue
        {
            Stack<int> stack1 = new Stack<int>();
            Stack<int> stack2 = new Stack<int>();

            public void enqueue(int n)
            {
                stack1.Push(n);
            }

            public int dequeue()
            {
                if (stack2.Count > 0)
                {
                    return stack2.Pop();
                }
                
                while (stack1.Count > 0)
                {
                    stack2.Push(stack1.Pop());
                }
                
                return stack2.Pop();
            }

        }

        static void Main(string[] args)
        {
            MyQueue myQueue = new MyQueue();

            myQueue.enqueue(1);
            myQueue.enqueue(2);
            myQueue.enqueue(3);
            myQueue.enqueue(4);

            Console.WriteLine(myQueue.dequeue()); // 1
            Console.WriteLine(myQueue.dequeue()); // 2

            myQueue.enqueue(5);
            myQueue.enqueue(6);

            Console.WriteLine(myQueue.dequeue()); // 3
            Console.WriteLine(myQueue.dequeue()); // 4
            Console.WriteLine(myQueue.dequeue()); // 5

            Console.Read();


            // 65
            // 34


        }


        
    }



    
}
