using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());

            int daysCounter = 0;
            int spendingCounter = 0;

            while (availableMoney < moneyNeeded && spendingCounter < 5)
            {
                string saveSpend = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                daysCounter++;

                if(saveSpend == "save")
                {
                    availableMoney += money;
                    spendingCounter = 0;
                }
                else
                {
                    availableMoney -= money;
                    spendingCounter++;

                    if(availableMoney < 0)
                    {
                        availableMoney = 0;
                    }

                }
            }

            if (spendingCounter == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{daysCounter}");
            }
            if(availableMoney >= moneyNeeded)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }

        }
    }
}
