using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double totalMoney = 0;

            while (input != "Start")
            {
                double currentAmount = double.Parse(input);

                if (currentAmount == 0.1)
                {
                    totalMoney += currentAmount;
                }
                else if (currentAmount == 0.2)
                {
                    totalMoney += currentAmount;
                }
                else if (currentAmount == 0.5)
                {
                    totalMoney += currentAmount;
                }
                else if (currentAmount == 1)
                {
                    totalMoney += currentAmount;
                }
                else if (currentAmount == 2)
                {
                    totalMoney += currentAmount;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {currentAmount}");
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "End")
            {
                double currentPrice = 0;
                string currentItem = "";
                switch (input)
                {
                    case "Nuts":
                        currentPrice = 2.0;
                        currentItem = "nuts";
                        break;
                    case "Water":
                        currentPrice = 0.7;
                        currentItem = "water";
                        break;
                    case "Crisps":
                        currentPrice = 1.5;
                        currentItem = "crisps";
                        break;
                    case "Soda":
                        currentPrice = 0.8;
                        currentItem = "soda";
                        break;
                    case "Coke":
                        currentPrice = 1.0;
                        currentItem = "coke";
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        currentItem = "";
                        break;
                }

                if(currentItem != "")
                {
                    if (totalMoney >= currentPrice)
                    {
                        Console.WriteLine($"Purchased {currentItem}");
                        totalMoney -= currentPrice;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Change: {totalMoney:f2}");
        }
    }
}
