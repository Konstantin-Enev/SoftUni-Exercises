using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmentPrice = 0;

            double studioTotal = 0.0;
            double apartmentTotal = 0.0;

            double discount = 1;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50.00;
                    apartmentPrice = 65.00;
                    
                    if(nights > 14)
                    {
                        discount = 0.70;
                    }
                    else if(nights >= 7)
                    {
                        discount = 0.95;
                    }
                    break;
                case "June":
                case "September":
                    studioPrice = 75.20;
                    apartmentPrice = 68.70;
                    if (nights > 14)
                    {
                        discount = 0.80;
                    }
                    break;
                case "July":
                case "August":
                    studioPrice = 76.00;
                    apartmentPrice = 77.00;
                    break;
            }

            studioTotal = nights * studioPrice * discount;
            if(nights > 14)
            {
                apartmentTotal = nights * apartmentPrice * 0.90;
            }
            else
            {
                apartmentTotal = nights * apartmentPrice;
            }

            Console.WriteLine($"Apartment: {apartmentTotal:f2} lv.");
            Console.WriteLine($"Studio: {studioTotal:f2} lv.");

        }
    }
}
