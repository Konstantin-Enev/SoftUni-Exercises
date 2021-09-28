using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();

            int maxPassangers = int.Parse(Console.ReadLine());

            ListSorter(wagons, maxPassangers);

            Console.WriteLine(string.Join(" ", wagons));
        }

        private static void ListSorter(List<int> wagons, int maxPassangers)
        {
            while (true)
            {
                string command = Console.ReadLine();

                string[] commandArgs = command.Split();

                if (command == "end")
                {
                    break;
                }

                if (commandArgs[0] == "Add")
                {
                    int passangers = int.Parse(commandArgs[1]);
                    wagons.Add(passangers);
                }
                else
                {
                    int passangers = int.Parse(commandArgs[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passangers <= maxPassangers)
                        {
                            wagons[i] += passangers;
                            break;
                        }
                    }
                }
            }
        }
    }
}
