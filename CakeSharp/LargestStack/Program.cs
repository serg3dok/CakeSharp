using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestStack
{

    /*
     * You want to be able to access the largest element in a stack.
     * Use the built-in Stack class to implement a new class MaxStack with a function GetMax() 
     * that returns the largest element in the stack. 
     * GetMax() should not remove the item.
     * Your stacks will contain only integers.
     */

    class MaxStack
    {
        public static int getMax(Stack<int> stack1)
        {
            int max = Int32.MinValue;
            Stack<int> stack2 = new Stack<int>();

            while (stack1.Count > 0)
            {
                max = Math.Max(max, stack1.Peek());
                stack2.Push(stack1.Pop());
            }

            // put it back
            while (stack2.Count > 0)
            {
                stack1.Push(stack2.Pop());
            }


            return max;
        }
    }

    class Program
    {
        

        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(5);
            stack.Push(8);
            stack.Push(2);
            stack.Push(19);
            stack.Push(0);
            stack.Push(-5);

            Console.WriteLine(MaxStack.getMax(stack));
            Console.Read();

        }
    }
}
