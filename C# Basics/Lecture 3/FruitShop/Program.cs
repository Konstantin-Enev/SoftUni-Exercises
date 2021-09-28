using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());

            double total = 0;

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (fruit)
                    {
                        case "banana":
                            total = amount * 2.50;
                            Console.WriteLine($"{total:f2}");
                            break;
                        case "apple":
                            total = amount * 1.20;
                            Console.WriteLine($"{total:f2}");
                            break;
                        case "orange":
                            total = amount * 0.85;
                            Console.WriteLine($"{total:f2}");
                            break;
                        case "grapefruit":
                            total = amount * 1.45;
                            Console.WriteLine($"{total:f2}");
                            break;
                        case "kiwi":
                            total = amount * 2.70;
                            Console.WriteLine($"{total:f2}");
                            break;
                        case "pineapple":
                            total = amount * 5.50;
                            Console.WriteLine($"{total:f2}");
                            break;
                        case "grapes":
                            total = amount * 3.85;
                            Console.WriteLine($"{total:f2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "Saturday":
                case "Sunday":
                    switch (fruit)
                    {
                        case "banana":
                            total = amount * 2.70;
                            Console.WriteLine($"{total:f2}");
                            break;
                        case "apple":
                            total = amount * 1.25;
                            Console.WriteLine($"{total:f2}");
                            break;
                        case "orange":
                            total = amount * 0.90;
                            Console.WriteLine($"{total:f2}");
                            break;
                        case "grapefruit":
                            total = amount * 1.60;
                            Console.WriteLine($"{total:f2}");
                            break;
                        case "kiwi":
                            total = amount * 3.00;
                            Console.WriteLine($"{total:f2}");
                            break;
                        case "pineapple":
                            total = amount * 5.60;
                            Console.WriteLine($"{total:f2}");
                            break;
                        case "grapes":
                            total = amount * 4.20;
                            Console.WriteLine($"{total:f2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }

        }
    }
}
