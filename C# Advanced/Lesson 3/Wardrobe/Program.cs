using System;
using System.Linq;
using System.Collections.Generic;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string colour = input[0];
                string[] items = input[1].Split(',', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (!wardrobe.ContainsKey(colour))
                {
                    wardrobe[colour] = new Dictionary<string, int>();
                    FillOrBuildSubDict(wardrobe, colour, items);
                }
                else
                {
                    FillOrBuildSubDict(wardrobe, colour, items);
                }
            }

            string[] st = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            string colourToLookFor = st[0];
            bool isColourFound = false;
            string itemToLookFor = st[1];
            bool isItemFound = false;
            PrintDictonary(wardrobe, colourToLookFor, ref isColourFound, itemToLookFor, ref isItemFound);
        }

        private static void PrintDictonary(Dictionary<string, Dictionary<string, int>> wardrobe, string colourToLookFor, ref bool isColourFound, string itemToLookFor, ref bool isItemFound)
        {
            foreach (var collection in wardrobe)
            {
                string colour = collection.Key;
                var clothes = collection.Value;
                Console.WriteLine($"{colour} clothes:");
                if (colour == colourToLookFor) isColourFound = true;
                foreach (var items in clothes)
                {
                    string item = items.Key;
                    int amount = items.Value;
                    if (item == itemToLookFor) isItemFound = true;
                    if (isColourFound == true && isItemFound == true)
                    {
                        Console.WriteLine($"* {item} - {amount} (found!)");
                        isItemFound = false; isColourFound = false;
                    }
                    else
                    {
                        Console.WriteLine($"* {item} - {amount}");
                    }
                }
            }
        }

        private static void FillOrBuildSubDict(Dictionary<string, Dictionary<string, int>> wardrobe, string colour, string[] items)
        {
            foreach (var item in items)
            {
                if (!wardrobe[colour].ContainsKey(item))
                {
                    wardrobe[colour].Add(item, 1);
                }
                else
                {
                    wardrobe[colour][item]++;
                }
            }
        }
    }
}
