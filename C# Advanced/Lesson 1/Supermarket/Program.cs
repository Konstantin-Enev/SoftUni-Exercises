using System;
using System.Collections.Generic;
using System.Linq;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> customers = new Queue<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }
                else if (input == "Paid")
                {
                    Console.WriteLine(string.Join("\n", customers));
                    customers.Clear();
                }
                else
                {
                    customers.Enqueue(input);
                }
            }

            Console.WriteLine($"{customers.Count} people remaining.");
        }
    }
}
