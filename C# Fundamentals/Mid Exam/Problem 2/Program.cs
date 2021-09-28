using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> favGenres = Console.ReadLine().Split(" | ", StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if(command == "Stop!")
                {
                    break;
                }

                string[] commandArgs = command.Split(" ");

                switch (commandArgs[0])
                {
                    case "Join":
                        if (favGenres.Contains(commandArgs[1]))
                        {
                            continue;
                        }
                        else
                        {
                            favGenres.Add(commandArgs[1]);
                        }
                        break;
                    case "Drop":
                        if (favGenres.Contains(commandArgs[1]))
                        {
                            favGenres.Remove(commandArgs[1]);
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case "Replace":
                        if (favGenres.Contains(commandArgs[1]) && !favGenres.Contains(commandArgs[2]))
                        {
                            favGenres.Insert(favGenres.IndexOf(commandArgs[1]), commandArgs[2]);
                            favGenres.Remove(commandArgs[1]);
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", favGenres));
        }
    }
}
