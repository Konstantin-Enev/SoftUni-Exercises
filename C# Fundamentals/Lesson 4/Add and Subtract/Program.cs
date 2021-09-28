using System;

namespace Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            Console.WriteLine(Subtract(Sum(first, second), third));
        }

        private static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        private static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
