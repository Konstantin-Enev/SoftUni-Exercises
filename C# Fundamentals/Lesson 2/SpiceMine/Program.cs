using System;

namespace SpiceMine
{
    class Program
    {
        static void Main(string[] args)
        {
            int spicePerDay = int.Parse(Console.ReadLine());

            int spiceTotal = 0;
            int numberOfDays = 0;

            while (spicePerDay >= 100)
            {
                spiceTotal += spicePerDay;
                spiceTotal -= 26;
                numberOfDays += 1;

                spicePerDay -= 10;

            }

            spiceTotal -= 26;

            Console.WriteLine(numberOfDays);
            Console.WriteLine(spiceTotal);

        }
    }
}
