using System;

namespace Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int counter = int.Parse(Console.ReadLine());

            string finalString = RepeatString(input, counter);
            Console.WriteLine(finalString);
        }

        private static string RepeatString(string str, int count)
        {
            string result = "";

            for(int i = 0; i < count; i++)
            {
                result += str;
            }

            return result;
        }
    }
}
