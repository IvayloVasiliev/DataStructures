using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveOddOccurrences
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                int count = 0;
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (numbers[j] == numbers[i])
                    {
                        count++;
                    }

                }

                if (count  % 2 == 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }


        }
    }
}
