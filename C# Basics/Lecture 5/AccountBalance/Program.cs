using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double sum = 0.0;

            while (input != "NoMoreMoney")
            {

                double number = double.Parse(input);

                if(number < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else
                {
                    sum += number;
                    Console.WriteLine($"Increase: {number:f2}");
                }

                input = Console.ReadLine();

            }

            Console.WriteLine($"Total: {sum:f2}");

        }
    }
}
