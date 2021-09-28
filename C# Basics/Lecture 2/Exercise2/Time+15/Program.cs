using System;

namespace Time_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int extraTime = 15;

            if ((extraTime + minutes) < 60)
            {
                minutes = extraTime + minutes;
            }
            else
            {
                minutes = (extraTime + minutes) - 60;
                hours = hours + 1;
                if (hours >= 24)
                {
                    hours = hours - 24;
                }
            }

            Console.WriteLine($"{hours}:{minutes:d2}");
        }
    }
}
