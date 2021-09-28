using System;
using System.Linq;

namespace Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimentions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            char[,] matrix = new char[dimentions[0], dimentions[1]];
            string snake = Console.ReadLine();
            int z = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if(i % 2 == 0)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = snake[z];
                        z++;
                        if (z == snake.Length) z = 0;
                    }
                }
                else
                {
                    for (int j = matrix.GetLength(1) - 1; j>= 0; j--)
                    {
                        matrix[i, j] = snake[z];
                        z++;
                        if (z == snake.Length) z = 0;
                    }
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
