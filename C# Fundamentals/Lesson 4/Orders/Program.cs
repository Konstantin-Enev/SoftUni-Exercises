using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int amount = int.Parse(Console.ReadLine());

            Total(input, amount);

        }

        static void Total(string product, int amount)
        {
            double price = 0;

            switch (product)
            {
                case "coffee":
                    price = 1.50;
                    break;
                case "water":
                    price = 1.00;
                    break;
                case "coke":
                    price = 1.40;
                    break;
                case "snacks":
                    price = 2.00;
                    break;
            }

            Console.WriteLine($"{(amount * price):f2}");

        }
    }
}
