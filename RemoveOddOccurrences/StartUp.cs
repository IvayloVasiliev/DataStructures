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

            Dictionary<int, int> occurences = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (!occurences.ContainsKey(numbers[i]))
                {
                    occurences.Add(numbers[i], 0);
                }

                occurences[numbers[i]] += 1;
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (occurences[numbers[i]] % 2 == 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }

        }
    }
}
