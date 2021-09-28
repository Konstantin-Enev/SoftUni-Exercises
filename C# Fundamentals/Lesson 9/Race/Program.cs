using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] racers = Console.ReadLine().Split(", ");

            string lettersRegex = @"[A-Z-a-z]";
            string numberRegex = @"[0-9]";

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "end of race")
                {
                    break;
                }


            }
        }
    }
}
