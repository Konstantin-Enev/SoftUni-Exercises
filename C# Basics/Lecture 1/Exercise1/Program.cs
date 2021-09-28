using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FruitMarket
            //double strawberryPrice = double.Parse(Console.ReadLine());

            //double bananas = double.Parse(Console.ReadLine());

            //double oranges = double.Parse(Console.ReadLine());

            //double raspberries = double.Parse(Console.ReadLine());

            //double strawberries = double.Parse(Console.ReadLine());

            //double raspberryPrice = strawberryPrice / 2;

            //double orangePrice = raspberryPrice - raspberryPrice * 0.4;

            //double bananPrice = raspberryPrice - raspberryPrice * 0.8;

            //double totalSum = (strawberries * strawberryPrice) + (oranges * orangePrice)
            //    + (bananas * bananPrice) + (raspberries * raspberryPrice);

            //Console.WriteLine(totalSum) 
            #endregion;

            #region Aquarium
            int lenght = int.Parse(Console.ReadLine());

            int width = int.Parse(Console.ReadLine());

            int height = int.Parse(Console.ReadLine());

            double waterPercent = double.Parse(Console.ReadLine()) * 0.01;

            int volume = lenght * width * height;

            double waterCapacity = volume * 0.001;

            double waterTotal = waterCapacity * (1 - waterPercent);

            Console.WriteLine(waterTotal); 
            #endregion

        }
    }
}
