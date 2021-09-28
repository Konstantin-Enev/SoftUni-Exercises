using System;
using System.Collections.Generic;
using System.Linq;

namespace Mu_Online
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rooms = Console.ReadLine().Split("|").ToList();
            int health = 100;
            int bitcoins = 0;

            for (int i = 0; i < rooms.Count; i++)
            {
                string[] roomArgs = rooms.ElementAt(i).Split(" ");
                string currentRoom = roomArgs[0];

                switch (roomArgs[0])
                {
                    case "potion":
                        int amountToHeal = int.Parse(roomArgs[1]);
                        if (health + amountToHeal >= 100)
                        {
                            amountToHeal = 100 - health;
                            health = 100;
                        }
                        else
                        {
                            health += amountToHeal;
                        }
                        Console.WriteLine($"You healed for {amountToHeal} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                        break;
                    case "chest":
                        int amount = int.Parse(roomArgs[1]);
                        bitcoins += amount;
                        Console.WriteLine($"You found {amount} bitcoins.");
                        break;
                    default:
                        health = health - int.Parse(roomArgs[1]);
                        if (health <= 0)
                        {
                            Console.WriteLine($"You died! Killed by {currentRoom}.");
                            Console.WriteLine($"Best room: {i + 1}");
                            return;
                        }
                        else
                        {
                            Console.WriteLine($"You slayed {currentRoom}.");
                        }
                        break;
                }

            }

            if(health != 0)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}
