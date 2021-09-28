using System;
using System.Collections.Generic;
using System.Linq;

namespace Guess_Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            for(int i = 0; i < numbers.Count / 2; i++)
            {
                double left = numbers[i];
                double right = numbers[numbers.Count - 1];

                numbers[i] = left + right;
                numbers.RemoveAt(numbers.Count - 1);
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
