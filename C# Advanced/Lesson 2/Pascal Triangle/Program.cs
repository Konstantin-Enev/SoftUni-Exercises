using System;
using System.Linq;

namespace Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            long height = long.Parse(Console.ReadLine());

            long[][] pascal = new long[height][];

            for (int i = 0; i < height; i++)
            {
                pascal[i] = new long[i + 1];
                pascal[i][0] = 1;
                pascal[i][pascal[i].Length - 1] = 1;
                for (long j = 1; j < pascal[i].Length - 1; j++)
                {
                    pascal[i][j] = pascal[i - 1][j - 1] + pascal[i - 1][j];
                }
            }

            for(int i = 0; i < height; i++)
            {
                Console.WriteLine(string.Join(" ", pascal[i]));
            }
        }
    }
}
