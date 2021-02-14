using System;
using System.Collections.Generic;
using System.Linq;

namespace StackImplementation
{
    


    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Stack Exercise");
            Stack<int> stk = new Stack<int>();
            stk.Push(10);
            stk.Push(20);
            stk.Push(30);
            stk.Push(40);
            Console.WriteLine(" Stack is pushed");
            foreach (Object obj in stk)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("Pop: '{0}'", stk.Pop());
            foreach (Object obj in stk)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("Peek: '{0}'", stk.Peek());
            foreach (Object obj in stk)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("Length: " + stk.Count());

        }
    }
}
