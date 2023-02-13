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
