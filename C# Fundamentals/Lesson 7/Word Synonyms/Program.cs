using System;
using System.Collections.Generic;
using System.Linq;

namespace Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> synonymsDict = new Dictionary<string, List<string>>();

            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!synonymsDict.ContainsKey(word))
                {
                    synonymsDict.Add(word, new List<string>());
                }

                synonymsDict[word].Add(synonym);
            }

            foreach(var item in synonymsDict)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}
