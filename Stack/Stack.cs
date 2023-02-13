using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack
    {
        public Node top;

        public Stack()
        {
            this.top = null;
        }
        public void push(int data)
        {
            Node newNode = new Node(data);
            if (top == null)
            {
                newNode.next = null;
            }
            else
            {
                newNode.next = top;
            }
            top = newNode;
            Console.WriteLine(" Pushed to Stack is :" + data);
        }
        public void peak()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            Console.WriteLine($"{this.top.data} is on the Top of the Stack");
        }
        public void pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            Console.WriteLine($"Item Popeed is {this.top.data}");
            top = top.next;
        }

        public void display()
        {
            int i = 1;
           
            Node temp = top;
            if (temp == null)
            {
                Console.WriteLine(" Stack is Empty");
            }
            while (temp != null)
            {
                Console.WriteLine($" Element {i} in the Stack is : " + temp.data);
                temp = temp.next;
                
                
            }
           
        }
    }
}
