using System;
using System.Collections.Generic;
using System.Linq;

namespace Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> usernames = Console.ReadLine().Split(", ").ToList();

            foreach (string username in usernames)
            {
                if (username.All(c => char.IsLetterOrDigit(c) || c == '_' || c == '-') && username.Length >= 3 && username.Length <= 16)
                {
                    Console.WriteLine(username);
                }
            }
        }
    }
}
