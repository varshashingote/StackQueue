using System;
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

        }
    }
}
