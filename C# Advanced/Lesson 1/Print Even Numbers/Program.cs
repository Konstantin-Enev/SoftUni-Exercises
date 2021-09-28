using System;
using System.Collections.Generic;
using System.Linq;

namespace Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> numbers = new Queue<int>();
            int counter = input.Length;

            for (int i = 0; i < counter; i++)
            {
                if (input[i] % 2 == 0)
                {
                    numbers.Enqueue(input[i]);
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
