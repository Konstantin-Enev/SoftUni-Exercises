using System;
using System.Linq;

namespace Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {

            int rows = integer();
            int[][] jagged = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                jagged[i] = ArrayRead();

            }

            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] parts = input.Split(' ').ToArray();
                string line = parts[0];
                int r = int.Parse(parts[1]);
                int c = int.Parse(parts[2]);
                int value = int.Parse(parts[3]);
                bool first = (r >= 0 && r < rows);
                bool second = (c >= 0 && c < rows);

                if (line == "Add")
                {

                    if (first && second)
                    {
                        jagged[r][c] += value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                else if (line == "Subtract")
                {
                    if (first && second)
                    {
                        jagged[r][c] -= value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var idx in jagged)
            {
                Console.WriteLine(string.Join(' ', idx));
            }
        }

        private static int integer()
        {
            return int.Parse(Console.ReadLine());
        }

        private static int[] ArrayRead()
        {
            int[] input = Console.ReadLine().Split(new string[] { ", ", " " }
                    , StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            return input;
        }
    }
}
