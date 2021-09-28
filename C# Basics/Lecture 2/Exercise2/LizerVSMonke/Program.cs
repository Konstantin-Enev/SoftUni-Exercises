using System;

namespace LizerVSMonke
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int extras = int.Parse(Console.ReadLine());
            double clothingPrice = double.Parse(Console.ReadLine());

            double directorPrice = budget * 0.10;
            double clothingTotal = 0.0;

            if (extras < 150)
            {
                clothingTotal = extras * clothingPrice;
            }
            else
            {
                clothingTotal = (extras * clothingPrice) *0.90;
            }

            double totalBudget = directorPrice + clothingTotal;

            double endAmount = budget - (directorPrice + clothingTotal);


            if (budget >= totalBudget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {endAmount:f2} leva left.");
            }
            else
            {
                endAmount = Math.Abs(endAmount);
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {endAmount:f2} leva more.");
            }


        }
    }
}
