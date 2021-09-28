using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string location = "";
            string vecationType = "";

            if(budget <= 100)
            {
                location = "Bulgaria";
                if(season == "summer")
                {
                    vecationType = "Camp";
                    budget = budget * 0.30;
                }
                else
                {
                    vecationType = "Hotel";
                    budget = budget * 0.70;
                }
            }
            else if(budget <= 1000)
            {
                location = "Balkans";
                if (season == "summer")
                {
                    vecationType = "Camp";
                    budget = budget * 0.40;
                }
                else
                {
                    vecationType = "Hotel";
                    budget = budget * 0.80;
                }
            }
            else
            {
                location = "Europe";
                vecationType = "Hotel";
                budget = budget * 0.90;
            }

            Console.WriteLine($"Somewhere in {location}");
            Console.WriteLine($"{vecationType} - {budget:f2}");

        }
    }
}
