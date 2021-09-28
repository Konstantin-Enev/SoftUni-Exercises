using System;

namespace CatFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int catCount = int.Parse(Console.ReadLine());

            int group1 = 0;
            int group2 = 0;
            int group3 = 0;
            double foodTotal = 0;


            for(int i = 1; i <= catCount; i++)
            {
                double foodGrams = double.Parse(Console.ReadLine());

                if(foodGrams >= 100 && foodGrams < 200)
                {
                    group1++;
                    foodTotal += foodGrams;
                }
                else if(foodGrams >= 200 && foodGrams < 300)
                {
                    group2++;
                    foodTotal += foodGrams;
                }
                else if (foodGrams >= 300 && foodGrams < 400)
                {
                    group3++;
                    foodTotal += foodGrams;
                }

            }

            double foodPrice = (foodTotal / 1000) * 12.45;

            Console.WriteLine($"Group 1: {group1} cats.");
            Console.WriteLine($"Group 2: {group2} cats.");
            Console.WriteLine($"Group 3: {group3} cats.");
            Console.WriteLine($"Price for food per day: {foodPrice:f2} lv.");

        }
    }
}
