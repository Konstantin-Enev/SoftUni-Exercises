using System;

namespace PreExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int paintBoxes = int.Parse(Console.ReadLine());
            int wallpaperRolls = int.Parse(Console.ReadLine());
            double glovePrice = double.Parse(Console.ReadLine());
            double brushPrice = double.Parse(Console.ReadLine());

            double paintPrice = 21.50;
            double wallpaperPrice = 5.20;

            double glovesAmount = Math.Ceiling(0.35 * wallpaperRolls);
            double brushesAmount = Math.Floor(0.48 * paintBoxes);

            double deliverCost = (paintPrice * paintBoxes + brushPrice * brushesAmount + glovePrice * glovesAmount + wallpaperPrice * wallpaperRolls) / 15;

            Console.WriteLine($"This delivery will cost {deliverCost:f2} lv.");



        }
    }
}
