using System;

namespace Sum_Char
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLines = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= numberLines; i++)
            {
                char input = char.Parse(Console.ReadLine());

                sum += (int)input;

            }

            Console.WriteLine($"The sum equals: {sum}");

        }
    }
}
