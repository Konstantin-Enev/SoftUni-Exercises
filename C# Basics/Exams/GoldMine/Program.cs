using System;

namespace GoldMine
{
    class Program
    {
        static void Main(string[] args)
        {
            int locations = int.Parse(Console.ReadLine());

            for(int i = 0; i < locations; i++)
            {
                double expectedAmount = double.Parse(Console.ReadLine());
                int daysAmount = int.Parse(Console.ReadLine());
                double averageAmount = 0;


                for(int j = 0; j < daysAmount; j++)
                {
                    double currentAmount = double.Parse(Console.ReadLine());

                    averageAmount += currentAmount;

                }

                if((averageAmount / (double)daysAmount) >= expectedAmount)
                {
                    Console.WriteLine($"Good job! Average gold per day: {(averageAmount / (double)daysAmount):f2}.");
                }
                else
                {
                    Console.WriteLine($"You need {expectedAmount - (averageAmount / (double)daysAmount):f2} gold.");
                }

            }


        }
    }
}
