using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chatMessages = new List<string>();

            while (true)
            {
                string command = Console.ReadLine();

                if(command == "end")
                {
                    break;
                }

                string[] commandArgs = command.Split(" ");

                switch (commandArgs[0])
                {
                    case "Chat":
                        chatMessages.Add(commandArgs[1]);
                        break;
                    case "Delete":
                        if (chatMessages.Contains(commandArgs[1]))
                        {
                            chatMessages.Remove(commandArgs[1]);
                        }
                        break;
                    case "Edit":
                        if (chatMessages.Contains(commandArgs[1]))
                        {
                            chatMessages.Insert(chatMessages.IndexOf(commandArgs[1]), commandArgs[2]);
                            chatMessages.Remove(commandArgs[1]);
                        }
                        break;
                    case "Pin":
                        if (chatMessages.Contains(commandArgs[1]))
                        {
                            chatMessages.Remove(commandArgs[1]);
                            chatMessages.Add(commandArgs[1]);
                        }
                        break;
                    case "Spam":
                        for(int i = 1; i < commandArgs.Length; i++)
                        {
                            chatMessages.Add(commandArgs[i]);
                        }
                        break;
                }
            }

            foreach(string element in chatMessages)
            {
                Console.WriteLine(element);
            }
        }
    }
}
