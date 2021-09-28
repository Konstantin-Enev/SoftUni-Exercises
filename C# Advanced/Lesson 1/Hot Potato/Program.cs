using System;
using System.Collections.Generic;
using System.Linq;

namespace Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int counter = int.Parse(Console.ReadLine());
            Queue<string> kids = new Queue<string>(input);

            while(kids.Count > 1)
            {
                for (int i = 0; i < counter - 1; i++)
                {
                    var potatoKid = kids.Dequeue();
                    kids.Enqueue(potatoKid);
                }

                var kidToLose = kids.Dequeue();
                Console.WriteLine($"Removed {kidToLose}");
            }

            Console.WriteLine($"Last is {kids.Dequeue()}");
        }
    }
}
