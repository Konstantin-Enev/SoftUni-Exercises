using System;
using System.Linq;
using System.Collections.Generic;

namespace Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> elements = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                foreach(var element in input)
                {
                    elements.Add(element);
                }
            }

            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
