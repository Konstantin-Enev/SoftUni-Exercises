using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine().Split("!").ToList();

            while (true)
            {
                string command = Console.ReadLine();
                string[] commandArgs = command.Split(" ");

                if(command == "Go Shopping!")
                {
                    break;
                }

                switch (commandArgs[0])
                {
                    case "Urgent":
                        if (groceries.Contains(commandArgs[1]))
                        {
                            continue;
                        }
                        else
                        {
                            groceries.Insert(0, commandArgs[1]);
                        }
                        break;
                    case "Unnecesarry":
                        if (groceries.Contains(commandArgs[1]))
                        {
                            groceries.Remove(commandArgs[1]);
                        }
                            break;
                    case "Correct":
                        if (groceries.Contains(commandArgs[1]))
                        {
                            groceries[groceries.FindIndex(item => item.Equals(commandArgs[1]))] = commandArgs[2];
                        }
                            break;
                    case "Rearrange":
                        if (groceries.Contains(commandArgs[1]))
                        {
                            groceries.Remove(commandArgs[1]);
                            groceries.Add(commandArgs[1]);
                        }
                        break;

                }
            }

            Console.WriteLine(string.Join(", ", groceries));
        }
    }
}
