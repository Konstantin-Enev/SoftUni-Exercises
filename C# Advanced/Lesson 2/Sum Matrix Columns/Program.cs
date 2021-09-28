using System;
using System.Linq;

namespace Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] elements = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int n = 0; n < matrix.GetLength(1); n++)
                {
                    matrix[i, n] = elements[n];
                }
            }

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                int sum = 0;

                for (int n = 0; n < matrix.GetLength(0); n++)
                {
                    sum += matrix[n, i];
                }

                Console.WriteLine(sum);
            }
        }
    }
}
