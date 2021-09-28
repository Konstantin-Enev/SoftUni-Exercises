using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string biggestName = string.Empty;

            double currentSize = 0;

            for (int i = 0; i < n; i++)
            {
                string kegName = Console.ReadLine();
                double kegRad = double.Parse(Console.ReadLine());
                int kegHeight = int.Parse(Console.ReadLine());

                double kegSize = Math.PI * Math.Pow(kegRad, 2) * kegHeight;

                if (currentSize < kegSize)
                {
                    currentSize = kegSize;
                    biggestName = kegName;
                }

            }

            Console.WriteLine(biggestName);

        }
    }
}
