using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> elements = Console.ReadLine().Split().Select(int.Parse).ToList();
            ListChange(elements);

            Console.WriteLine(string.Join(" ", elements));
        }

        private static void ListChange(List<int> elements)
        {
            while (true)
            {
                string command = Console.ReadLine();

                string[] commandArgs = command.Split();

                if (command == "end")
                {
                    break;
                }

                switch (commandArgs[0])
                {
                    case "Delete":
                        elements.RemoveAll(e => e == int.Parse(commandArgs[1]));
                        break;
                    case "Insert":
                        elements.Insert(int.Parse(commandArgs[2]), int.Parse(commandArgs[1]));
                        break;
                }
            }
        }
    }
}
