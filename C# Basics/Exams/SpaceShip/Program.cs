using System;

namespace SpaceShip
{
    class Program
    {
        static void Main(string[] args)
        {
            double shipWidth = double.Parse(Console.ReadLine());
            double shipLenght = double.Parse(Console.ReadLine());
            double shipHeight = double.Parse(Console.ReadLine());
            double astronautHeightAvg = double.Parse(Console.ReadLine());

            double shipVolume = shipHeight * shipLenght * shipWidth;
            double roomVolume = 2 * 2 * (astronautHeightAvg + 0.40);

            int crewSize = (int)Math.Floor(shipVolume / roomVolume);

            if(crewSize >= 3 && crewSize <= 10)
            {
                Console.WriteLine($"The spacecraft holds {crewSize} astronauts.");
            }
            else if(crewSize < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else
            {
                Console.WriteLine("The spacecraft is too big.");
            }

        }
    }
}
