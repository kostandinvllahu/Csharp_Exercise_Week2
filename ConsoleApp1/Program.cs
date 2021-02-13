using System;
using System.Collections.Generic;

namespace StackImplementation
{
    


    class Program
    {

    
        
        public static void Push()
        {
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
        }
        
        public static void Pop()
        {
            Stack<int> stk = new Stack<int>();
            stk.Push(10);
            stk.Push(20);
            stk.Push(30);
            stk.Push(40);
            Console.WriteLine("The pop stack");
            Console.WriteLine("POP STACK IS: " + stk.Pop());
            foreach (Object obj in stk)
            {
                Console.WriteLine(obj);
            }
        }

        public static void Peep()
        {
            Stack<int> stk = new Stack<int>();
            stk.Push(10);
            stk.Push(20);
            stk.Push(30);
            stk.Push(40);
            Console.WriteLine("The peep stack");
            Console.WriteLine("PEEP STACK IS: " + stk.Peek());
            foreach (Object obj in stk)
            {
                Console.WriteLine(obj);
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Stack Exercise");
            Push();
            Pop();
            Peep();
        }
    }
}
