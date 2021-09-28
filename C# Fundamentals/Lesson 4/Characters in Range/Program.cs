using System;

namespace Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());

            PrintCharacters(first, second);
        }

        private static void PrintCharacters(char startChar, char endChar)
        {
            int start = (int)startChar;
            int end = (int)endChar;

            if(start > end)
            {
                for (int i = end + 1; i < start; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            else
            {
                for (int i = start + 1; i < end; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
        }
    }
}
