using System;
using System.Linq;

namespace Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            int sumFirst = 0;
            int sumSecond = 0;

            for(int r = 0; r < matrix.GetLength(0); r++)
            {
                int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = elements[c];
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sumFirst += matrix[i, i];
            }

            for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
            {
                sumSecond += matrix[matrix.GetLength(0) - 1 - i, i];
            }

            int result = Math.Abs(sumSecond - sumFirst);

            Console.WriteLine(result);
        }
    }
}
