using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int numberToDivide = int.Parse(input);

            int divisionNumber = 0;

            if (numberToDivide % 10 == 0)
            {
                divisionNumber = 10;
            }
            else if (numberToDivide % 7 == 0)
            {
                divisionNumber = 7;
            }
            else if (numberToDivide % 6 == 0)
            {
                divisionNumber = 6;
            }
            else if (numberToDivide % 3 == 0)
            {
                divisionNumber = 3;
            }
            else if (numberToDivide % 2 == 0)
            {
                divisionNumber = 2;
            }

            if (divisionNumber == 0)
            {
                Console.WriteLine("Not divisible");
            }
            else
            {
                Console.WriteLine("The number is divisible by " + divisionNumber);
            }

        }
    }
}
