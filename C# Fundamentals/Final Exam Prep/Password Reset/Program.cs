using System;
using System.Linq;
using System.Text;

namespace Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            while (true)
            {
                string command = Console.ReadLine();
                string[] commandArgs = command.Split(" ").ToArray();

                if (command == "Done")
                {
                    break;
                }

                switch (commandArgs[0])
                {
                    case "TakeOdd":
                        StringBuilder odd = new StringBuilder();

                        for(int i = 1; i < password.Length; i+= 2)
                        {
                            odd.Append(password[i]);
                        }
                        password = odd.ToString();
                        Console.WriteLine(password);
                        break;
                    case "Cut":
                        int index = int.Parse(commandArgs[1]);
                        int lenght = int.Parse(commandArgs[2]);

                        password = password.Remove(index, lenght);
                        Console.WriteLine(password);
                        break;
                    case "Substitute":
                        string oldString = commandArgs[1];
                        string newString = commandArgs[2];

                        if(password.IndexOf(oldString) < 0)
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                        else
                        {
                            password = password.Replace(oldString, newString);
                        }
                        Console.WriteLine(password);
                        break;
                }
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
