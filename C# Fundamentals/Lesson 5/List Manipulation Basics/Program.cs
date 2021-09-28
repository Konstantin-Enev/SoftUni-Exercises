using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            ManipulationLoop(numbers);

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void ManipulationLoop(List<int> numbers)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] tokens = input.Split();

                switch (tokens[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(tokens[1]));
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(tokens[1]));
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(tokens[1]));
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(tokens[2]), int.Parse(tokens[1]));
                        break;
                }
            }
        }
    }
}
