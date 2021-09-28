﻿using System;
using System.Text.RegularExpressions;

namespace Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"([:*])\1([A-Z][a-z]{2,})\1{2}");
            long coolThresholdSum = 1;

            for(int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]))
                {
                    coolThresholdSum *= input[i] - 48;
                }
            }

            Console.WriteLine($"Cool threshold: {coolThresholdSum}");

            MatchCollection matches = regex.Matches(input);

            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");
            foreach (Match match in matches)
            {
                int coolness = 0;
                string emoji = match.Groups[2].Value;

                for (int i = 0; i < emoji.Length; i++)
                {
                    coolness += emoji[i];
                }

                if(coolness > coolThresholdSum)
                {
                    Console.WriteLine(match.Value);
                }
            }
        }
    }
}
