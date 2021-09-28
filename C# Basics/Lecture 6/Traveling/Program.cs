using System;

namespace Traveling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destinationInput = Console.ReadLine();

            while (destinationInput != "End")
            {

                int budget = int.Parse(Console.ReadLine());

                int savedTotal = 0;
                while (savedTotal < budget)
                {
                    int savedAmount = int.Parse(Console.ReadLine());

                    savedTotal += savedAmount;
                }

                if (savedTotal >= budget)
                {
                    Console.WriteLine($"Going to {destinationInput}!");
                    savedTotal = 0;
                }

                destinationInput = Console.ReadLine();

            }
        }
    }
}
