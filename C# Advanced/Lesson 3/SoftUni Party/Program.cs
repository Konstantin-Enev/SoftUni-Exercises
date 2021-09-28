using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> guests = new HashSet<string>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "PARTY")
                {
                    break;
                }
                else
                {
                    guests.Add(command);
                }
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }
                else
                {
                    if (guests.Contains(command))
                    {
                        guests.Remove(command);
                    }
                }
            }

            Console.WriteLine(guests.Count);
            foreach (var guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
