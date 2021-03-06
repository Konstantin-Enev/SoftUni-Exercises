using System;
using System.Collections.Generic;
using System.Linq;

namespace Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerDeck = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondPlayerDeck = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();


            while (true)
            {

                if (firstPlayerDeck.FirstOrDefault() > secondPlayerDeck.FirstOrDefault())
                {

                    firstPlayerDeck.Add(firstPlayerDeck.FirstOrDefault());
                    firstPlayerDeck.Remove(firstPlayerDeck.FirstOrDefault());
                    firstPlayerDeck.Add(secondPlayerDeck.FirstOrDefault());
                    secondPlayerDeck.Remove(secondPlayerDeck.FirstOrDefault());
                }

                else if (secondPlayerDeck.FirstOrDefault() > firstPlayerDeck.FirstOrDefault())
                {
                    secondPlayerDeck.Add(secondPlayerDeck.FirstOrDefault());
                    secondPlayerDeck.Remove(secondPlayerDeck.FirstOrDefault());
                    secondPlayerDeck.Add(firstPlayerDeck.FirstOrDefault());
                    firstPlayerDeck.Remove(firstPlayerDeck.FirstOrDefault());
                }

                else
                {
                    firstPlayerDeck.Remove(firstPlayerDeck.FirstOrDefault());
                    secondPlayerDeck.Remove(secondPlayerDeck.FirstOrDefault());

                }

                if (firstPlayerDeck.Count == 0)
                {
                    Console.WriteLine($"Second player wins! Sum: {secondPlayerDeck.Sum()}");
                    break;
                }
                else if (secondPlayerDeck.Count == 0)
                {
                    Console.WriteLine($"First player wins! Sum: {firstPlayerDeck.Sum()}");
                    break;
                }
            }
        }
    }
}
