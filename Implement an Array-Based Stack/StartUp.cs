using System;

namespace Implement_an_Array_Based_Stack
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ArrayStack<int> stack = new ArrayStack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            

            Console.WriteLine(string.Join(", ", stack.ToArray()));

        }
    }
}
