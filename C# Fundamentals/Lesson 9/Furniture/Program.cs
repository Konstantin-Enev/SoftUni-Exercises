using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @">>(?<name>[A-Za-z]+)<<(?<price>\d+(.\d+)?)!(?<quant>\d+)";

            List<string> items = new List<string>();

            double totalCost = 0.0;

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Purchase")
                {
                    break;
                }

                Match m = Regex.Match(input, regex, RegexOptions.IgnoreCase);

                if (m.Success)
                {
                    var name = m.Groups["name"].Value;
                    var price = double.Parse(m.Groups["price"].Value);
                    var quant = int.Parse(m.Groups["quant"].Value);

                    items.Add(name);
                    totalCost += price * quant;
                }
            }

            Console.WriteLine("Bought furniture:");
            if(items.Count > 0)
            {
                Console.WriteLine($"{string.Join(Environment.NewLine, items)}");
            }
            Console.WriteLine($"Total money spend: {totalCost:F2}");
        }
    }
}
