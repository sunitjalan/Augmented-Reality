using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        public class Queue
        {
            public Stack stack1 = new Stack();
            public Stack stack2 = new Stack();
            public void enQueue(int n)
            {
                while (stack1.Count > 0)
                {
                    stack2.Push(stack1.Pop());
                }
                stack1.Push(n);
                while (stack2.Count > 0)
                {
                    stack1.Push(stack2.Pop());
                }
            }
            public int deQueue()
            {
                if (stack1.Count == 0)
                {
                    Console.WriteLine("Q is Empty");

                }
                int x = (int)stack1.Peek();
                stack1.Pop();
                return x;
            }
        };
        public static void Main()
        {
            Queue q = new Queue();
            q.enQueue(0);
            q.enQueue(1);
            q.enQueue(2);
            q.enQueue(3);

            Console.Write(q.deQueue() + "\t");
            Console.Write(q.deQueue() + "\t");
            Console.Write(q.deQueue() + "\t");
            Console.Write(q.deQueue());
            Console.WriteLine();
        }
    }
}
