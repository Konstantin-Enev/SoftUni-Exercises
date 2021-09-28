using System;
using System.Collections.Generic;
using System.Linq;

namespace Cities_byContinent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string inputLine = Console.ReadLine();
                string[] commandArgs = inputLine.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string continent = commandArgs[0];
                string country = commandArgs[1];
                string city = commandArgs[2];

                if (!continents.ContainsKey(continent))
                {
                    continents[continent] = new Dictionary<string, List<string>>();
                    if (!continents[continent].ContainsKey(country))
                    {
                        continents[continent][country] = new List<string>();
                        continents[continent][country].Add(city);
                    }
                    else
                    {
                        continents[continent][country].Add(city);
                    }
                }
                else
                {
                    if (!continents[continent].ContainsKey(country))
                    {
                        continents[continent][country] = new List<string>();
                        continents[continent][country].Add(city);
                    }
                    else
                    {
                        continents[continent][country].Add(city);
                    }
                }
            }

            foreach(var continent in continents)
            {
                string continentName = continent.Key;
                var countries = continent.Value;

                Console.WriteLine($"{continentName}:");
                foreach(var country in countries)
                {
                    string countryName = country.Key;
                    var cities = country.Value;

                    Console.Write($"{countryName} -> ");
                    Console.WriteLine(string.Join(", ", cities));
                }
            }
        }
    }
}
