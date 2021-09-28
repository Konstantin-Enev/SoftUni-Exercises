using System;

namespace Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(RaiseToPower(input, power));
        }

        static double RaiseToPower(double number, int power)
        {
            double result =

            Math.Pow(number, power);

            return result;
        }
    }
}
