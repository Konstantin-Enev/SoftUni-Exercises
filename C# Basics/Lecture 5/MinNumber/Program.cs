using System;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int result = int.MaxValue;

            while (input != "Stop")
            {

                int number = int.Parse(input);

                if (number < result)
                {
                    result = number;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(result);

        }
    }
}
