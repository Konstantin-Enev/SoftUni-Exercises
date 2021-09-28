using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commandArgs = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            if (commandArgs[0] == 0)
            {
                Console.WriteLine("0");
                return;
            }
            int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Queue<int> numbers = new Queue<int>(nums);

            int numToDeque = commandArgs[1];
            int numToFind = commandArgs[2];

            for(int i = 0; i < numToDeque; i++)
            {
                numbers.Dequeue();
            }

            if(numbers.Count == 0)
            {
                Console.WriteLine("0");
                return;
            }

            bool flag = numbers.Contains(numToFind);
            Console.WriteLine(flag ? "true" : $"{numbers.Min()}");
        }
    }
}
