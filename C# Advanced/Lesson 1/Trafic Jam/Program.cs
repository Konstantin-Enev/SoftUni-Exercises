using System;
using System.Collections.Generic;
using System.Linq;

namespace Trafic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            int sum = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }
                else if (command == "green")
                {
                    if(cars.Count > 0)
                    {
                        if (cars.Count >= counter)
                        {
                            for (int i = 0; i < counter; i++)
                            {
                                Console.WriteLine($"{cars.Dequeue()} passed!");
                                sum++;
                            }
                        }
                        else
                        {
                            for (int i = 0; i <= cars.Count; i++)
                            {
                                Console.WriteLine($"{cars.Dequeue()} passed!");
                                sum++;
                            }
                        }
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }
            }

            Console.WriteLine($"{sum} cars passed the crossroads.");
        }
    }
}
