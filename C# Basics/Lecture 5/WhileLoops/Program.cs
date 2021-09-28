using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            while(word != "Stop")
            {
                Console.WriteLine(word);
                word = Console.ReadLine();
            }

        }
    }
}
