using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodAmount = int.Parse(Console.ReadLine());
            int[] foodOrders = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Queue<int> clientOrders = new Queue<int>(foodOrders);

            Console.WriteLine(clientOrders.Max());

            while(foodAmount > 0)
            {
                int x = clientOrders.Peek();
                if(foodAmount - x >= 0)
                {
                    foodAmount -= x;
                    clientOrders.Dequeue();
                }
                else
                {
                    break;
                }
            }

            string result = clientOrders.Count >= 1 ? $"Orders left: {string.Join(" ", clientOrders)}" : "Orders complete";
            Console.WriteLine(result);
        }
    }
}
