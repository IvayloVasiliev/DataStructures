using System;
using System.Collections.Generic;

namespace SequenceNM
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //a program that finds the shortest sequence of operations 

            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            if (startNum > endNum)
            {
                Console.WriteLine("no solution");
            }

            Queue<Item> queue = new Queue<Item>();

            Item startItem = new Item();

            startItem.value = startNum;

            queue.Enqueue(startItem);

            while (true)
            {
                Item element = queue.Dequeue();

                if (element.value == endNum)
                {
                    while (element != null)
                    {
                        Console.WriteLine(element.value);
                        element = element.prevItem;
                    }
                    return;
                }

                queue.Enqueue(new Item(element.value + 1, element));
                queue.Enqueue(new Item(element.value + 2, element));
                queue.Enqueue(new Item(element.value * 2, element));
            }


        }
    }
}
