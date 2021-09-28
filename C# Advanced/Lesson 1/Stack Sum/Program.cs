using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            Stack<int> numbers = new Stack<int>();

            foreach(string ch in input)
            {
                int current = int.Parse(ch);
                numbers.Push(current);
            }

            while (true)
            {
                string command = Console.ReadLine().ToLower();
                string[] commandArgs = command.Split(' ');

                if(commandArgs[0] == "end")
                {
                    break;
                }
                else if(commandArgs[0] == "add")
                {
                    numbers.Push(int.Parse(commandArgs[1]));
                    numbers.Push(int.Parse(commandArgs[2]));
                }
                else if(commandArgs[0] == "remove")
                {
                    int amountToRemove = int.Parse(commandArgs[1]);

                    if(amountToRemove < numbers.Count)
                    {
                        for(int i = 0; i < amountToRemove; i++)
                        {
                            numbers.Pop();
                        }
                    }
                }
            }

            int sum = numbers.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
