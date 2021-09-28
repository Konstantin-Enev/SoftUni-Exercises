using System;

namespace National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            int receptionist1 = int.Parse(Console.ReadLine());
            int receptionist2 = int.Parse(Console.ReadLine());
            int receptionist3 = int.Parse(Console.ReadLine());
            int peopleCount = int.Parse(Console.ReadLine());
            int receptionistTotal = receptionist1 + receptionist2 + receptionist3;

            int timeCounter = 0;

            while(peopleCount > 0)
            {
                timeCounter++;
                if(timeCounter % 4 == 0)
                {
                    continue;
                }
                peopleCount -= receptionistTotal;
            }

            Console.WriteLine($"Time needed: {timeCounter}h.");
        }
    }
}
