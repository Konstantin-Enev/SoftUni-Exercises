using System;

namespace CatLife
{
    class Program
    {
        static void Main(string[] args)
        {
            string catBreed = Console.ReadLine();
            char catGender = char.Parse(Console.ReadLine());
            int catAge = 0;

            switch (catBreed)
            {
                case "British Shorthair":
                    if(catGender == 'm')
                    {
                        catAge = (13 * 12) / 6;
                        Console.WriteLine($"{catAge} cat months");
                    }
                    else
                    {
                        catAge = (14 * 12) / 6;
                        Console.WriteLine($"{catAge} cat months");
                    }
                    break;
                case "Siamese":
                    if (catGender == 'm')
                    {
                        catAge = (15 * 12) / 6;
                        Console.WriteLine($"{catAge} cat months");
                    }
                    else
                    {
                        catAge = (16 * 12) / 6;
                        Console.WriteLine($"{catAge} cat months");
                    }
                    break;
                case "Persian":
                    if (catGender == 'm')
                    {
                        catAge = (14 * 12) / 6;
                        Console.WriteLine($"{catAge} cat months");
                    }
                    else
                    {
                        catAge = (15 * 12) / 6;
                        Console.WriteLine($"{catAge} cat months");
                    }
                    break;
                case "Ragdoll":
                    if (catGender == 'm')
                    {
                        catAge = (16 * 12) / 6;
                        Console.WriteLine($"{catAge} cat months");
                    }
                    else
                    {
                        catAge = (17 * 12) / 6;
                        Console.WriteLine($"{catAge} cat months");
                    }
                    break;
                case "American Shorthair":
                    if (catGender == 'm')
                    {
                        catAge = (12 * 12) / 6;
                        Console.WriteLine($"{catAge} cat months");
                    }
                    else
                    {
                        catAge = (13 * 12) / 6;
                        Console.WriteLine($"{catAge} cat months");
                    }
                    break;
                case "Siberian":
                    if (catGender == 'm')
                    {
                        catAge = (11 * 12) / 6;
                        Console.WriteLine($"{catAge} cat months");
                    }
                    else
                    {
                        catAge = (12 * 12) / 6;
                        Console.WriteLine($"{catAge} cat months");
                    }
                    break;
                default:
                    Console.WriteLine($"{catBreed} is invalid cat!");
                    break;
            }


        }
    }
}
