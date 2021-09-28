using System;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance1 = double.Parse(Console.ReadLine());
            string metric1 = Console.ReadLine();
            string metric2 = Console.ReadLine();

            if(metric1 == "mm")
            {
                if(metric2 == "cm")
                {
                    double distance2 = distance1 / 10;
                    Console.WriteLine($"{distance2:f3}");
                }
                else
                {
                    double distance2 = distance1 / 1000;
                    Console.WriteLine($"{distance2:f3}");
                }
            }
            if (metric1 == "cm")
            {
                if (metric2 == "mm")
                {
                    double distance2 = distance1 * 10;
                    Console.WriteLine($"{distance2:f3}");
                }
                else
                {
                    double distance2 = distance1 / 100;
                    Console.WriteLine($"{distance2:f3}");
                }
            }
            if (metric1 == "m")
            {
                if (metric2 == "mm")
                {
                    double distance2 = distance1 * 1000;
                    Console.WriteLine($"{distance2:f3}");
                }
                else
                {
                    double distance2 = distance1 * 100;
                    Console.WriteLine($"{distance2:f3}");
                }
            }

        }
    }
}
