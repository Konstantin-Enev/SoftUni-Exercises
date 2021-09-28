using System;
using System.Linq;

namespace _2X2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowCol = Console.ReadLine().Split().Select(int.Parse).ToArray();
            char[,] matrix = new char[rowCol[0], rowCol[1]];

            int sqrCount = 0;

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                char[] elements = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = elements[c];
                }
            }

            for (int r = 0; r < matrix.GetLength(0) - 1; r++)
            { 
                for (int c = 0; c < matrix.GetLength(1) - 1; c++)
                {
                    if(matrix[r, c] == matrix[r, c + 1] && matrix[r, c] == matrix[r + 1, c] && matrix[r, c] == matrix[r + 1, c + 1])
                    {
                        sqrCount++;
                    }
                }
            }

            Console.WriteLine(sqrCount);
        }
    }
}
