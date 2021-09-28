using System;

namespace PuppyCare
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogFood = int.Parse(Console.ReadLine());

            int dogFoodGrams = dogFood * 1000;

            string command = Console.ReadLine();

            while (command != "Adopted")
            {
                int eatenFood = int.Parse(command);
                dogFoodGrams -= eatenFood;

                command = Console.ReadLine();

            }

            if(dogFoodGrams >= 0)
            {
                Console.WriteLine($"Food is enough! Leftovers: {dogFoodGrams} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {Math.Abs(dogFoodGrams)} grams more.");
            }


        }
    }
}
