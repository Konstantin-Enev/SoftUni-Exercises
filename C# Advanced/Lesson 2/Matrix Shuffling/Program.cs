using System;
using System.Linq;

namespace Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimentions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[dimentions[0], dimentions[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                
                var line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = line[j];
                }
            }

            while (true)
            {
                string commandLine = Console.ReadLine();
                if (commandLine.Contains("END"))
                {
                    break;
                }
                string[] commandArgs = commandLine.Split(' ').ToArray();

                int firstRow = int.Parse(commandArgs[1]);
                int firstCol = int.Parse(commandArgs[2]);
                int secondRow = int.Parse(commandArgs[3]);
                int secondCol = int.Parse(commandArgs[4]);

                if (commandArgs.Length < 5 && commandArgs.Length >= 6 && commandArgs[0] != "swap")
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    if (firstCol > matrix.GetLength(1) && secondCol > matrix.GetLength(1) && firstRow > matrix.GetLength(0) && secondRow > matrix.GetLength(0))
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }
                    int currentNum = matrix[firstRow, firstCol];
                    int swapNum = matrix[secondRow, secondCol];

                    matrix[firstRow, firstCol] = swapNum;
                    matrix[secondRow, secondCol] = currentNum;

                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            Console.Write(matrix[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                }    
            }
        }
    }
}
