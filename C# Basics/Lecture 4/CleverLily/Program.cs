using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washerPrice = double.Parse(Console.ReadLine());
            double toysPrice = double.Parse(Console.ReadLine());

            double moneyHolder = 0;
            int toysCounter = 0;
            int stolenMoney = 0;
            int moneyPresent = 10;

            for(int i = 1; i <= age; i++)
            {
                if(i%2 != 0)
                {
                    toysCounter++;
                }
                else
                {
                    stolenMoney++;
                    moneyHolder += moneyPresent;
                    moneyPresent += 10;
                }
            }

            double moneyFromToys = toysCounter * toysPrice;

            double finalResult = (moneyHolder + moneyFromToys) - stolenMoney;

            if(finalResult >= washerPrice)
            {
                Console.WriteLine($"Yes! {(finalResult - washerPrice):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(washerPrice - finalResult):f2}");
            }
            
        }
    }
}
