using System;
using System.Collections.Generic;
using System.Linq;

namespace Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine == "Revision")
                {
                    break;
                }
                string[] lineArgs = inputLine.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string shopName = lineArgs[0];
                string productName = lineArgs[1];
                double price = double.Parse(lineArgs[2]);

                if (!shops.ContainsKey(shopName))
                {
                    shops[shopName] = new Dictionary<string, double>();
                    shops[shopName][productName] = price;
                }
                else
                {
                    shops[shopName][productName] = price;
                }

            }

            foreach(var shop in shops)
            {
                string shopName = shop.Key;
                var shopProducts = shop.Value;

                Console.WriteLine($"{shopName}->");
                foreach(var product in shopProducts)
                {
                    string productName = product.Key;
                    double productPrice = product.Value;
                    Console.WriteLine($"Product: {productName}, Price: {productPrice}");
                }
            }
        }
    }
}
