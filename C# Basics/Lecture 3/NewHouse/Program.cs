using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int amount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double totalPrice = 0;
            double cost = 0;

            switch (flowerType)
            {
                case "Roses":
                    cost = 5.00;
                    if(amount > 80)
                    {
                        totalPrice = (amount * cost) * 0.90;
                    }
                    else
                    {
                        totalPrice = amount * cost;
                    }
                    break;
                case "Dahlias":
                    cost = 3.80;
                    if (amount > 90)
                    {
                        totalPrice = (amount * cost) * 0.85;
                    }
                    else
                    {
                        totalPrice = amount * cost;
                    }
                    break;
                case "Tulips":
                    cost = 2.8;
                    if (amount > 80)
                    {
                        totalPrice = (amount * cost) * 0.85;
                    }
                    else
                    {
                        totalPrice = amount * cost;
                    }
                    break;
                case "Narcissus":
                    if (amount < 120)
                    {
                        totalPrice = (amount * cost) * 1.15;
                    }
                    else
                    {
                        totalPrice = amount * cost;
                    }
                    cost = 3;
                    break;
                case "Gladiolus":
                    cost = 2.50;
                    if (amount < 80)
                    {
                        totalPrice = (amount * cost) * 1.20;
                    }
                    else
                    {
                        totalPrice = amount * cost;
                    }
                    break;
            }

            if(budget >= totalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {amount} {flowerType} and {(budget - totalPrice):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(totalPrice - budget):f2} leva more.");
            }

        }
    }
}
