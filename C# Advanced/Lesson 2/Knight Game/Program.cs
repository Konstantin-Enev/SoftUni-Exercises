using System;
using System.Linq;

namespace Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                string elements = Console.ReadLine();
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = elements[c];
                }
            }

            int removedKnights = 0;

            while(true)
            {
                int maxAttacks = 0;
                int knightRow = 0;
                int knightCol = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        int currentAttacks = 0;

                        if (matrix[row, col] != 'K')
                        {
                            continue;
                        }

                        if (IsInside(matrix, row - 2, col + 1) && matrix[row - 2, col + 1] == 'K')
                        {
                            currentAttacks++;
                        }
                        if (IsInside(matrix, row - 1, col + 2) && matrix[row - 1, col + 2] == 'K')
                        {
                            currentAttacks++;
                        }
                        if (IsInside(matrix, row + 1, col + 2) && matrix[row + 1, col + 2] == 'K')
                        {
                            currentAttacks++;
                        }
                        if (IsInside(matrix, row + 2, col + 1) && matrix[row + 2, col + 1] == 'K')
                        {
                            currentAttacks++;
                        }
                        if (IsInside(matrix, row + 2, col - 1) && matrix[row + 2, col - 1] == 'K')
                        {
                            currentAttacks++;
                        }
                        if (IsInside(matrix, row + 1, col - 2) && matrix[row + 1, col - 2] == 'K')
                        {
                            currentAttacks++;
                        }
                        if (IsInside(matrix, row - 1, col - 2) && matrix[row - 1, col - 2] == 'K')
                        {
                            currentAttacks++;
                        }
                        if (IsInside(matrix, row - 2, col - 1) && matrix[row - 2, col - 1] == 'K')
                        {
                            currentAttacks++;
                        }

                        if (currentAttacks > maxAttacks)
                        {
                            maxAttacks = currentAttacks;
                            knightRow = row;
                            knightCol = col;
                        }
                    }
                }

                if(maxAttacks == 0)
                {
                    Console.WriteLine(removedKnights);
                    break;
                }
                else
                {
                    matrix[knightRow, knightCol] = '0';
                    removedKnights++;
                }
            }
        }

        private static bool IsInside(char[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) &&
                col >= 0 && col < matrix.GetLength(1);
        }
    }
}
