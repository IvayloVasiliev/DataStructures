using System;

namespace LinkedStack
{
    class StartUp
    {
        static void Main(string[] args)
        {
            LinkedStack<int> stack = new LinkedStack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            stack.Pop();

            Console.WriteLine(string.Join(", ", stack.ToArray()));
        }
    }
}
