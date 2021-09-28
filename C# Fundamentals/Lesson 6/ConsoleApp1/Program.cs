using System;
using System.Collections.Generic;

namespace Advertisment
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();

            List<string> Phrases = new List<string>() { "Excellent product.", "Such a great product.",
                "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            List<string> Events = new List<string>() { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            List<string> Authors = new List<string>() { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            List<string> Cities = new List<string>() { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int counter = int.Parse(Console.ReadLine());

            for(int i = 1; i <= counter; i++)
            {
                Advertisment currentMessage = new Advertisment();

                currentMessage.Phrase = Phrases[rng.Next(0, Phrases.Count - 1)];
                currentMessage.Event = Events[rng.Next(0, Events.Count - 1)];
                currentMessage.Author = Authors[rng.Next(0, Authors.Count - 1)];
                currentMessage.City = Cities[rng.Next(0, Cities.Count - 1)];

                Console.WriteLine($"{currentMessage.Phrase} {currentMessage.Event} {currentMessage.Author} – {currentMessage.City}.");
            }


        }
    }

    class Advertisment
    {
        public string Phrase { get; set; }

        public string Event { get; set; }

        public string Author { get; set; }

        public string City { get; set; }
    }
}
