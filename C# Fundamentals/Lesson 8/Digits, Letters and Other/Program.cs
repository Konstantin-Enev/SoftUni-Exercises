using System;

namespace Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            foreach(char character in text)
            {
                if (char.IsDigit(character))
                {
                    Console.Write(character);
                }
            }
            Console.WriteLine();
            foreach (char character in text)
            {
                if (char.IsLetter(character))
                {
                    Console.Write(character);
                }
            }
            Console.WriteLine();
            foreach (char character in text)
            {
                if (!char.IsLetterOrDigit(character))
                {
                    Console.Write(character);
                }
            }
            Console.WriteLine();
        }
    }
}
