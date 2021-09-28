using System;
using System.Linq;

namespace Square_with_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputParts = input.Split(", ");
            int rows = int.Parse(inputParts[0]);
            int cols = int.Parse(inputParts[1]);

            int[,] numbers = new int[rows, cols];

            for (int r = 0; r < numbers.GetLength(0); r++)
            {
                int[] elements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int c = 0; c < numbers.GetLength(1); c++)
                {
                    numbers[r, c] = elements[c];
                }
            }

            long maxSum = long.MinValue;
            int maxSumRow = 0;
            int maxSumCol = 0;

            for (int r = 0; r < numbers.GetLength(0) - 1; r++)
            {
                for (int c = 0; c < numbers.GetLength(1) - 1; c++)
                {
                    var sum = numbers[r, c] + numbers[r, c + 1] + numbers[r + 1, c] + numbers[r + 1, c + 1];
                    if(sum > maxSum)
                    {
                        maxSum = sum;
                        maxSumRow = r;
                        maxSumCol = c;
                    }
                }
            }

            for(int r = maxSumRow; r < maxSumRow + 2; r++)
            {
                for (int c = maxSumCol; c < maxSumCol + 2; c++)
                {
                    Console.Write(numbers[r, c] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(maxSum);
        }
    }
}
