using System;
using System.Text.RegularExpressions;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex boss = new Regex(@"\|([A-Z]{4,})\|");
            Regex title = new Regex(@":\#([A-Za-z]{1,}\s[A-Za-z]{1,})\#");

            int count = int.Parse(Console.ReadLine());

            for(int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();

                Match bossMatch = boss.Match(input);
                Match titleMatch = title.Match(input);
                if (bossMatch.Success && titleMatch.Success)
                {
                    string bossName = bossMatch.Groups[1].Value;
                    int strength = bossName.Length;
                    string bossTitle = titleMatch.Groups[1].Value;
                    int armor = bossTitle.Length;
                    Console.WriteLine($"{bossName}, The {bossTitle}");
                    Console.WriteLine($">> Strength: {strength}");
                    Console.WriteLine($">> Armor: {armor}");
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }
            }
        }
    }
}
