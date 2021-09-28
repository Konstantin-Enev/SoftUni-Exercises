using System;

namespace Math_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            string mathOperator = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(firstNumber, mathOperator, secondNumber));
        }

        private static double Calculate(int a, string @operator, int b)
        {
            double result = 0;

            switch (@operator)
            {
                case "/":
                    result = (double)a / b;
                    break;
                case "*":
                    result = (double)a * b;
                    break;
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
            }

            return result;
        }
    }
}
