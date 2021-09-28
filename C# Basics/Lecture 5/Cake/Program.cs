using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int with = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());

            int size = with * lenght;

            string input = Console.ReadLine();

            while (input != "STOP")
            {
                int pieces = int.Parse(input);

                size -= pieces;

                if(size <= 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(size)} pieces more.");
                    return;
                }
                else
                {
                    input = Console.ReadLine();
                }

            }

            Console.WriteLine($"{size} pieces are left.");

        }
    }
}
