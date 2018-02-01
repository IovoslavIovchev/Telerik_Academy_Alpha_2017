using System;
using System.Collections.Generic;

namespace Stack_Implementation
{
    class StartUp
    {
        static void Main()
        {
            Stack<int> stack = new Stack<int>(1);

            stack.Push(3);
            Console.WriteLine(stack.Peek());
            stack.Push(12);
            stack.Push(stack.Pop());
            Console.WriteLine(stack.Peek());
            stack.Push(111);
            Console.WriteLine(stack.Pop());
        }
    }
}
