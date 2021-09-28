using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> elements = Console.ReadLine().Split().Select(int.Parse).ToList();
            ListLoop(elements);

            Console.WriteLine(string.Join(" ", elements));
        }

        private static void ListLoop(List<int> elements)
        {
            while (true)
            {
                string command = Console.ReadLine();

                string[] commandArgs = command.Split();

                if (command == "End")
                {
                    break;
                }

                switch (commandArgs[0])
                {
                    case "Add":
                        elements.Add(int.Parse(commandArgs[1]));
                        break;
                    case "Insert":
                        if (int.Parse(commandArgs[2]) < 0 || int.Parse(commandArgs[2]) > elements.Count - 1)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        else
                        {
                            elements.Insert(int.Parse(commandArgs[2]), int.Parse(commandArgs[1]));
                        }
                        break;
                    case "Remove":
                        if (int.Parse(commandArgs[1]) < 0 || int.Parse(commandArgs[1]) > elements.Count - 1)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        else
                        {
                            elements.RemoveAt(int.Parse(commandArgs[1]));
                        }
                        break;
                    case "Shift":
                        ShiftList(elements, commandArgs);
                        break;

                }
            }
        }

        private static void ShiftList(List<int> elements, string[] commandArgs)
        {
            if (commandArgs[1] == "left")
            {
                int count = int.Parse(commandArgs[2]);

                for (int i = 0; i < count; i++)
                {
                    int currentFirst = elements.ElementAt(0);
                    elements.Add(currentFirst);
                    elements.RemoveAt(0);
                }
            }
            else if (commandArgs[1] == "right")
            {
                int count = int.Parse(commandArgs[2]);

                for (int i = 0; i < count; i++)
                {
                    int currentLast = elements.ElementAt(elements.Count - 1);
                    elements.Insert(0, currentLast);
                    elements.RemoveAt(elements.Count - 1);
                }
            }
        }
    }
}
