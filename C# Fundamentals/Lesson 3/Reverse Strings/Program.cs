using System;

namespace Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");

            for(int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i] + " ");
            }

        }
    }
}
