using System;

namespace Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"{Factorial(firstNumber) / Factorial(secondNumber):f2}"); 
        }

        private static double Factorial(int number)
        {
            double result = 1;

            for(int i = 1; i<= number; i++)
            {
                result = result * i;
            }

            return result;
        }

    }
}
