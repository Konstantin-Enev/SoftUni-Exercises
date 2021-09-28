using System;

namespace NumbersN
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (n = n; n >= 1; n--)
            {
                Console.WriteLine(n);
            }
        }
    }
}
