using System;

namespace Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintMiddleChar(input);
        }

        private static void PrintMiddleChar(string str)
        {
            char output = ' ';
            char secondOutput = ' ';

            if(str.Length % 2 == 0)
            {
                output = str[str.Length / 2 - 1];
                secondOutput = str[str.Length / 2];
                Console.WriteLine(output + "" + secondOutput);
            }
            else
            {
                output = str[str.Length / 2];
                Console.WriteLine(output);
            }
        }
    }
}
