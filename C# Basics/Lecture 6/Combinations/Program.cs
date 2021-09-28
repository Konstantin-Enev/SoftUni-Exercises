using System;

namespace Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int result = 0;

            for(int i = 0; i <= input; i++)
            {
                for (int y = 0; y <= input; y++)
                {
                    for (int x = 0; x <= input; x++)
                    {
                        if (i + y + x == input)
                        {
                            result++;
                        }
                    }
                }
            }

            Console.WriteLine(result);

        }
    }
}
