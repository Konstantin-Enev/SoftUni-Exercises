using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            bool isChanged = false;

            isChanged = ManipulationLoop(numbers, isChanged);
            
            if(isChanged == true)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }

        private static bool ManipulationLoop(List<int> numbers, bool isChanged)
        {
            isChanged = false;
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
                        isChanged = true;
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(tokens[1]));
                        isChanged = true;
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(tokens[1]));
                        isChanged = true;
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(tokens[2]), int.Parse(tokens[1]));
                        isChanged = true;
                        break;
                    case "Contains":
                        Contains(numbers, tokens);
                        break;
                    case "PrintEven":
                        PrintEven(numbers);
                        break;
                    case "PrintOdd":
                        PrintOdd(numbers);
                        break;
                    case "GetSum":
                        Console.WriteLine(numbers.Sum());
                        break;
                    case "Filter":
                        FilterList(numbers, tokens);
                        break;
                }
            }
            return isChanged;
        }

        private static void Contains(List<int> numbers, string[] tokens)
        {
            if (numbers.Contains(int.Parse(tokens[1])))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }

        private static void PrintOdd(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                int curentNumber = numbers[i];
                if (numbers[i] % 2 == 1)
                {
                    Console.Write(curentNumber + " ");
                }
            }
        }

        private static void PrintEven(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                int curentNumber = numbers[i];
                if (numbers[i] % 2 == 0)
                {
                    Console.Write(curentNumber + " ");
                }
            }
        }

        private static void FilterList(List<int> numbers, string[] tokens)
        {
            int index = int.Parse(tokens[2]);
            if (tokens[1] == "<")
            {
                Console.WriteLine(string.Join(" ", numbers.FindAll(x => x < index)));
            }
            if (tokens[1] == ">")
            {
                Console.WriteLine(string.Join(" ", numbers.FindAll(x => x > index)));
            }
            if (tokens[1] == "<=")
            {
                Console.WriteLine(string.Join(" ", numbers.FindAll(x => x <= index)));
            }
            if (tokens[1] == ">=")
            {
                Console.WriteLine(string.Join(" ", numbers.FindAll(x => x >= index)));
            }
        }
    }
}
