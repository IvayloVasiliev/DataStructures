using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestSubsequence
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToList();

            int maxNumber = 0;
            int maxCount = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                int counter = 1;
                for (int j = i+1; j < numbers.Count; j++)
                {
                    if (numbers[j] == numbers[i])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (counter > maxCount)
                {
                    maxNumber = numbers[i];
                    maxCount = counter;
                }
            }

            for (int i = 0; i < maxCount; i++)
            {
                Console.Write(maxNumber + " ");
            }
        }
    }
}
