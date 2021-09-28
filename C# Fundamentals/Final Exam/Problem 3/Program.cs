using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> Animals = new Dictionary<string, int>();
            Dictionary<string, int> Areas = new Dictionary<string, int>();
            Dictionary<string, string> AnimalsAreas = new Dictionary<string, string>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "EndDay")
                {
                    break;
                }

                string[] commandArgs = command.Split(new string[] { ": ", "-" }, StringSplitOptions.RemoveEmptyEntries);

                switch (commandArgs[0])
                {
                    case "Add":
                        if (Animals.ContainsKey(commandArgs[1]))
                        {
                            Animals[commandArgs[1]] += int.Parse(commandArgs[2]);
                        }
                        else
                        {
                            Animals.Add(commandArgs[1], int.Parse(commandArgs[2]));
                            AnimalsAreas.Add(commandArgs[1], commandArgs[3]);
                            if (Areas.ContainsKey(commandArgs[3]))
                            {
                                Areas[commandArgs[3]] += 1;
                            }
                            else
                            {
                                Areas.Add(commandArgs[3], +1);
                            }
                        }
                        break;
                    case "Feed":
                        if (Animals.ContainsKey(commandArgs[1]))
                        {
                            Animals[commandArgs[1]] -= int.Parse(commandArgs[2]);
                            if(Animals[commandArgs[1]] <= 0)
                            {
                                Console.WriteLine($"{commandArgs[1]} was successfully fed");
                                Animals.Remove(commandArgs[1]);
                                foreach(KeyValuePair<string,string> kvp in AnimalsAreas)
                                {
                                    if(kvp.Key == commandArgs[1])
                                    {
                                        string area = kvp.Value;
                                        if (Areas.ContainsKey(area))
                                        {
                                            Areas[area] -= 1;
                                            if(Areas[area] <= 0)
                                            {
                                                Areas.Remove(area);
                                            }
                                        }
                                        AnimalsAreas.Remove(commandArgs[1]);
                                    }
                                }
                            }
                        }
                        break;
                }
            }

            IOrderedEnumerable<KeyValuePair<string, int>> DictionarySort(Dictionary<string, int> dict)
            {
                return dict.OrderBy(i => i.Key).OrderByDescending(i => i.Value);
            }

            var animalSort = DictionarySort(Animals);

            var areaSort = DictionarySort(Areas);

            Console.WriteLine("Animals:");
            foreach(KeyValuePair<string, int> value in animalSort)
            {
                Console.WriteLine($"{value.Key} -> {value.Value}g");
            }
            Console.WriteLine("Areas with hungry animals:");
            foreach (KeyValuePair<string, int> value in areaSort)
            {
                Console.WriteLine($"{value.Key}: {value.Value}");
            }
        }
    }
}
