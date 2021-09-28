using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int result = int.MinValue;

            while (input != "Stop")
            {

                int number = int.Parse(input);

                if (number > result)
                {
                    result = number;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(result);

        }
    }
}
