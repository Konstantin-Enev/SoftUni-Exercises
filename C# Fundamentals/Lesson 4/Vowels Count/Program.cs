using System;

namespace Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintVowelCount(input);
        }

        private static void PrintVowelCount(string str)
        {
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                char currentChar = str[i];

                switch (currentChar)
                {
                    case 'a':
                        count += 1;
                        break;
                    case 'e':
                        count += 1;
                        break;
                    case 'i':
                        count += 1;
                        break;
                    case 'o':
                        count += 1;
                        break;
                    case 'u':
                        count += 1;
                        break;
                    case 'A':
                        count += 1;
                        break;
                    case 'E':
                        count += 1;
                        break;
                    case 'I':
                        count += 1;
                        break;
                    case 'O':
                        count += 1;
                        break;
                    case 'U':
                        count += 1;
                        break;
                }

            }

            Console.WriteLine(count);
        }
    }
}
