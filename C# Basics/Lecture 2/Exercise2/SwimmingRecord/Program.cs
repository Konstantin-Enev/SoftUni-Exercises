using System;

namespace SwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());

            double timeTotal = distance * timePerMeter;

            double index = Math.Floor(distance / 15);

            double addtionalTime = 12.5 * index;

            timeTotal += addtionalTime;

            if(timeTotal < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {timeTotal:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {(timeTotal - record):f2} seconds slower.");
            }

        }
    }
}
