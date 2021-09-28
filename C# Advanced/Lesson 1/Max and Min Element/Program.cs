using System;
using System.Collections.Generic;
using System.Linq;

namespace Max_and_Min_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                string[] commandArgs = command.Split(' ');

                switch (commandArgs[0])
                {
                    case "1":
                        numbers.Push(int.Parse(commandArgs[1]));
                        break;
                    case "2":
                        numbers.Pop();
                        break;
                    case "3":
                        if(numbers.Count > 0)
                        {
                            Console.WriteLine(numbers.Max());
                        }
                        break;
                    case "4":
                        if (numbers.Count > 0)
                        {
                            Console.WriteLine(numbers.Min());
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
