using System;
using System.Linq;

namespace Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] colElements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int n = 0; n < matrix.GetLength(1); n++)
                {
                    matrix[i, n] = colElements[n];
                }
            }

            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int n = 0; n < matrix.GetLength(1); n++)
                {
                    sum += matrix[i, n];
                }
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
