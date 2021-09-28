using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int tankCapacity = 255;
            int currentAmount = 0;

            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());

                if (currentAmount <= tankCapacity && currentAmount + liters <= tankCapacity)
                {
                    if (liters <= tankCapacity)
                    {
                        currentAmount += liters;
                    }
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(currentAmount);

        }
    }
}
