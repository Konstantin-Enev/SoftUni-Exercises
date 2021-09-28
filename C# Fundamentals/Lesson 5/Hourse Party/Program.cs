using System;
using System.Collections.Generic;
using System.Linq;

namespace Hourse_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGuests = int.Parse(Console.ReadLine());

            List<string> guests = new List<string>();
            GuestChecker(numberOfGuests, guests);

            for (int i = 0; i < guests.Count; i++)
            {
                Console.WriteLine(guests.ElementAt(i));
            }
        }

        private static void GuestChecker(int numberOfGuests, List<string> guests)
        {
            for (int i = 0; i <= numberOfGuests - 1; i++)
            {
                string command = Console.ReadLine();

                string[] commandArgs = command.Split();

                switch (commandArgs[2])
                {
                    case "going!":
                        if (guests.Contains(commandArgs[0]))
                        {
                            Console.WriteLine($"{commandArgs[0]} is already in the list!");
                        }
                        else
                        {
                            guests.Add(commandArgs[0]);
                        }
                        break;
                    case "not":
                        if (guests.Contains(commandArgs[0]))
                        {
                            guests.Remove(commandArgs[0]);
                        }
                        else
                        {
                            Console.WriteLine($"{commandArgs[0]} is not in the list!");
                        }
                        break;
                }
            }
        }
    }
}
