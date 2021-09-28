using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInital = int.Parse(Console.ReadLine());

            int currentNumber = numberInital;
            int sum = 0;

            while (numberInital > 0)
            {
                currentNumber = numberInital % 10;

                sum += currentNumber;

                numberInital /= 10;
            }

            Console.WriteLine(sum);

        }
    }
}
