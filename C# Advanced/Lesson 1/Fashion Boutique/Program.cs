using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());
            int sum = 0;
            int rackCounter = 1;
            Stack<int> clothes = new Stack<int>(input);

            while(clothes.Count > 0)
            {
                sum += clothes.Peek();
                if(sum <= rackCapacity)
                {
                    clothes.Pop();
                }
                else
                {
                    rackCounter++;
                    sum = 0;
                }
            }

            Console.WriteLine(rackCounter);
        }
    }
}
