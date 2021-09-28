using System;
using System.Linq;
using System.Collections.Generic;

namespace Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] set = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = set[0];
            int m = set[1];
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();
            HashSet<int> thirdSet = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());
                firstSet.Add(current);
            }
            for (int i = 0; i < m; i++)
            {
                int current = int.Parse(Console.ReadLine());
                secondSet.Add(current);
            }

            if(n > m)
            {
                foreach(var num in firstSet)
                {
                    if (secondSet.Contains(num))
                    {
                        thirdSet.Add(num);
                    }
                }
            }
            else
            {
                foreach(var num in secondSet)
                {
                    if (firstSet.Contains(num))
                    {
                        thirdSet.Add(num);
                    }
                }
            }
            if(thirdSet.Count > 0)
            {
                Console.WriteLine(string.Join(" ", thirdSet));
            }
            
        }
    }
}
