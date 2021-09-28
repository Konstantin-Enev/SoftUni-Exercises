using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commandArgs = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            if(commandArgs[0] == 0)
            {
                Console.WriteLine("0");
                return;
            }
            int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Stack<int> numbers = new Stack<int>(nums);

            int numToPop = commandArgs[1];
            int numToFind = commandArgs[2];

            for(int i = 0; i< numToPop; i++)
            {
                numbers.Pop();
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
