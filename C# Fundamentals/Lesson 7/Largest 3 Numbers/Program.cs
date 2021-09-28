using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int[] sortedNumbers = numbers.OrderByDescending(n => n).ToArray();

            if(sortedNumbers.Length >= 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(sortedNumbers[i] + " ");
                }
            }
            else
            {
                Console.WriteLine(string.Join(" ", sortedNumbers));
            }
        }
    }
}
