using System;
using System.Linq;


namespace Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[][] jagged = new double[n][];

            for (int i = 0; i < n; i++)
            {
                jagged[i] = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            }

            for (int row = 0; row < jagged.Length - 1; row++)
            {
                if (jagged[row].Length == jagged[row + 1].Length)
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] *= 2;
                        jagged[row + 1][col] *= 2;
                    }
                }
                else if (jagged[row].Length != jagged[row + 1].Length)
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] /= 2;
                    }
                    for (int col = 0; col < jagged[row + 1].Length; col++)
                    {
                        jagged[row + 1][col] /= 2;
                    }
                }
            }
            
            while (true)
            {
                string input = Console.ReadLine();
                string[] commandArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = commandArgs[0];
                if (command == "End")
                {
                    break;
                }
                int rowCord = int.Parse(commandArgs[1]);
                int colCord = int.Parse(commandArgs[2]);
                int value = int.Parse(commandArgs[3]);

                if (command == "Add" && commandArgs.Length == 4)
                {
                    if (rowCord < jagged.Length && rowCord >= 0)
                    {
                        if(colCord < jagged[rowCord].Length && colCord >= 0)
                        {
                            jagged[rowCord][colCord] += value;
                        }
                    }
                }
                else if(command == "Subtract" && commandArgs.Length == 4)
                {
                    if (rowCord < jagged.Length && rowCord >= 0)
                    {
                        if (colCord < jagged[rowCord].Length && colCord >= 0)
                        {
                            jagged[rowCord][colCord] -= value;
                        }
                    }
                }
            }

            foreach(double[] row in jagged)
            {
                Console.WriteLine(string.Join(" ",row));
            }
        }
    }
}
