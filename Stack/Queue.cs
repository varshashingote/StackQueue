using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Queue
    {
            Node front;
            Node rear;
            public void Enqueue(int data)
            {
                Node newNode = new Node(data);
                if (this.rear == null)
                {
                    this.front = this.rear = newNode;
                }
                else
                {
                    this.rear.next = newNode;
                    this.rear = newNode;
                }
                Console.WriteLine($"{data} Inserted into Queue");
            }
            public void Dequeue()
            {
                if (this.front == null)
                {
                    Console.WriteLine(" Queue is Empty");
                    return;
                }
                Node temp = this.front;
                this.front = this.front.next;

                if (this.front == null)
                {
                    this.rear = null;
                }

                Console.WriteLine("Element deleted is {0}", temp.data);
            }
            public void display()
            {
            int i = 1;

            Node temp = front;
            if (temp == null)
            {
                Console.WriteLine(" Queue is Empty");
            }
            while (temp != null)
            {
                Console.WriteLine($" Element {i} in the Queue is : " + temp.data);
                temp = temp.next;


            }

        }
    }
}



    

