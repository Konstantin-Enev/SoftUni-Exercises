using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string remover = Console.ReadLine();

            string text = Console.ReadLine();

            while (text.IndexOf(remover) >= 0)
            {
                text = text.Remove(text.IndexOf(remover), remover.Length);
            }

            Console.WriteLine(text);
        }
    }
}
