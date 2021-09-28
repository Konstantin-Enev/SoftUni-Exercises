using System;
using System.Linq;
using System.Collections.Generic;

namespace Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();

            foreach (char ch in input)
            {
                if (!symbols.ContainsKey(ch))
                {
                    symbols.Add(ch, 1);
                }
                else
                {
                    symbols[ch]++;
                }
            }

            foreach (var ch in symbols)
            {
                Console.WriteLine($"{ch.Key}: {ch.Value} time/s");
            }
        }
    }
}
