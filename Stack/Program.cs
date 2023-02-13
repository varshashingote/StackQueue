using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your choice 1.stack\n2.queue");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Stack stack = new Stack();
                    stack.push(56);
                    stack.push(30);
                    stack.push(70);
                    stack.peak();
                    stack.pop();
                    stack.peak();
                    stack.pop();
                    stack.peak();
                    stack.pop();
                    stack.display();
                    Console.ReadLine();
                    break;
                case 2:
                    Queue queue = new Queue();
                    queue.Enqueue(30);
                    queue.Enqueue(70);
                    queue.display();
                    queue.Dequeue();
                    queue.display();
                    queue.Dequeue();
                    queue.display();
                    queue.Dequeue();
                    queue.display(); ;
                    Console.ReadLine();
                    break;
                }
        }
    }
}
