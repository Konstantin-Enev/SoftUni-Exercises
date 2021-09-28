using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());

            int price = 0;
            double total = 0.0;

            switch (season)
            {
                case"Spring":
                    price = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    price = 4200;
                    break;
                case "Winter":
                    price = 2600;
                    break;
            }

            if(fishermen <= 6)
            {
                total = price * 0.90;
            }
            else if(fishermen >= 7 && fishermen <= 11)
            {
                total = price * 0.85;
            }
            else
            {
                total = price * 0.75;
            }

            if(fishermen % 2 == 0 && season != "Autumn")
            {
                total = total * 0.95;
            }

            if(budget >= total)
            {
                Console.WriteLine($"Yes! You have {(budget - total):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(total - budget):f2} leva.");
            }

        }
    }
}
