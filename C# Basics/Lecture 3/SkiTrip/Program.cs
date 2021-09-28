using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string feedback = Console.ReadLine();

            int nights = days - 1;
            double sumForAllNights = 0.0;

            if(roomType == "room for one person")
            {
                sumForAllNights = nights * 18.00;
            }
            else if(roomType == "apartment")
            {
                if (days < 10)
                {
                    sumForAllNights = (nights * 25) * 0.7;
                }
                else if (days >= 10 && days <= 15)
                {
                    sumForAllNights = (nights * 25) * 0.65;
                }
                else
                {
                    sumForAllNights = (nights * 25) * 0.5;
                }
            }
            else if(roomType == "president apartment")
            {
                if (days < 10)
                {
                    sumForAllNights = (nights * 35) * 0.9;
                }
                else if (days >= 10 && days <= 15)
                {
                    sumForAllNights = (nights * 35) * 0.85;
                }
                else
                {
                    sumForAllNights = (nights * 35) * 0.8;
                }
            }

            if(feedback == "positive")
            {
                sumForAllNights = sumForAllNights * 1.25;
            }
            else
            {
                sumForAllNights = sumForAllNights * 0.90;
            }


            Console.WriteLine($"{sumForAllNights:f2}");
        }
    }
}
