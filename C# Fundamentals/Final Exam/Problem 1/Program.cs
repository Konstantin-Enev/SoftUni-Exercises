using System;
using System.Text;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (true)
            {
                string command = Console.ReadLine();

                if(command == "End")
                {
                    break;
                }

                string[] commandArgs = command.Split(" ");

                switch (commandArgs[0])
                {
                    case "Translate":
                        if (input.Contains(commandArgs[1]))
                        {
                            input = input.Replace(commandArgs[1], commandArgs[2]);
                            Console.WriteLine(input);
                        }
                        break;
                    case "Includes":
                        if (input.Contains(commandArgs[1]))
                        {
                            Console.WriteLine(true);
                        }
                        else
                        {
                            Console.WriteLine(false);
                        }
                        break;
                    case "Start":
                        if (input.StartsWith(commandArgs[1]))
                        {
                            Console.WriteLine(true);
                        }
                        else
                        {
                            Console.WriteLine(false);
                        }
                        break;
                    case "Lowercase":
                        input = input.ToLower();
                        Console.WriteLine(input);
                        break;
                    case "FindIndex":
                        Console.WriteLine(input.LastIndexOf(commandArgs[1]));
                        break;
                    case "Remove":
                        input = input.Remove(int.Parse(commandArgs[1]), int.Parse(commandArgs[2]));
                        Console.WriteLine(input);
                        break;
                }
            }
        }
    }
}
