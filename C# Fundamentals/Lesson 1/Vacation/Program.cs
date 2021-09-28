using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double pricePerPerson = 0;
            double finalPrice = 0;


            switch (groupType)
            {
                case "Students":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            pricePerPerson = 8.45;
                            break;
                        case "Saturday":
                            pricePerPerson = 9.80;
                            break;
                        case "Sunday":
                            pricePerPerson = 10.46;
                            break;
                    }

                    finalPrice = (groupSize * 1.0) * pricePerPerson;
                    if(groupSize >= 30)
                    {
                        finalPrice = finalPrice * 0.85;
                    }

                    break;
                case "Business":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            pricePerPerson = 10.90;
                            break;
                        case "Saturday":
                            pricePerPerson = 15.60;
                            break;
                        case "Sunday":
                            pricePerPerson = 16;
                            break;
                    }

                    if(groupSize >= 100)
                    {
                        groupSize -= 10;
                    }
                    finalPrice = (groupSize * 1.0) * pricePerPerson;

                    break;
                case "Regular":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            pricePerPerson = 15;
                            break;
                        case "Saturday":
                            pricePerPerson = 20;
                            break;
                        case "Sunday":
                            pricePerPerson = 22.50;
                            break;
                    }

                    finalPrice = (groupSize * 1.0) * pricePerPerson;
                    if(groupSize >= 10 && groupSize <= 20)
                    {
                        finalPrice = finalPrice * 0.95;
                    }

                    break;
            }


            Console.WriteLine($"Total price: {finalPrice:f2}");
        }
    }
}
