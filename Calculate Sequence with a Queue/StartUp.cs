using System;
using System.Collections;
using System.Collections.Generic;

namespace Calculate_Sequence_with_a_Queue
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(num);

            int index = 0;
            int[] arr = new int[50];

            while (true)
            {
                int element = queue.Dequeue();

                arr[index] = element;
                index++;

                if (index == 50)
                {
                    break;
                }

                queue.Enqueue(element + 1);
                queue.Enqueue(2* element +1);
                queue.Enqueue(element + 2);
            }

            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
