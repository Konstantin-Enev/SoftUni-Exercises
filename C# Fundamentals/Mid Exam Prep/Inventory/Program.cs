using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> collection = Console.ReadLine().Split(", ").ToList();

            while (true)
            {
                string command = Console.ReadLine();
                if(command == "Craft!")
                {
                    break;
                }
                string[] commandArgs = command.Split(" - ");

                switch (commandArgs[0])
                {
                    case "Collect":
                        string currentItem = commandArgs[1];
                        if (collection.Contains(currentItem))
                        {
                            break;
                        }
                        else
                        {
                            collection.Add(currentItem);
                        }
                        break;
                    case "Drop":
                        currentItem = commandArgs[1];
                        if (collection.Contains(currentItem))
                        {
                            collection.Remove(currentItem);
                        }
                        else
                        {
                            break;
                        }
                        break;
                    case "Combine Items":
                        string[] items = commandArgs[1].Split(":");
                        if (collection.Contains(items[0]))
                        {
                            collection.Insert(collection.IndexOf(items[0]) + 1, items[1]);
                        }
                        break;
                    case "Renew":
                        currentItem = commandArgs[1];
                        if (collection.Contains(currentItem))
                        {
                            collection.Remove(currentItem);
                            collection.Add(currentItem);
                        }
                        else
                        {
                            break;
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", collection));
        }
    }
}
