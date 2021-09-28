using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());
            int coinCounter = 0;

            double convert = change * 100;
            int cent = (int)convert;

            while (cent > 0)
            {
                if (cent >= 200)
                {
                    cent -= 200;
                    coinCounter++;
                }
                else if (cent >= 100)
                {
                    cent -= 100;
                    coinCounter++;
                }
                else if (cent >= 50)
                {
                    cent -= 50;
                    coinCounter++;
                }
                else if (cent >= 20)
                {
                    cent -= 20;
                    coinCounter++;
                }
                else if (cent >= 10)
                {
                    cent -= 10;
                    coinCounter++;
                }
                else if (cent >= 5)
                {
                    cent -= 5;
                    coinCounter++;
                }
                else if (cent >= 2)
                {
                    cent -= 2;
                    coinCounter++;
                }
                else if (cent >= 1)
                {
                    cent -= 1;
                    coinCounter++;
                }

            }

            Console.WriteLine(coinCounter);

        }
    }
}
