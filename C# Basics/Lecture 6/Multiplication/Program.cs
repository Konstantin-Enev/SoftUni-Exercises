using System;

namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int h = 1; h <= 10; h++)
            {
                for (int m = 1; m <= 10; m++)
                {
                    int result = m * h;
                    Console.WriteLine($"{h} * {m} = {result}");
                }
            }
        }
    }
}
