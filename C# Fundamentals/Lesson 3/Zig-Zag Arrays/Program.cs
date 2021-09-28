using System;
using System.Linq;

namespace Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            int[] firstArray = new int[numberOfLines];
            int[] secondArray = new int[numberOfLines];

            for (int i = 0; i < numberOfLines; i++)
            {
                int[] currentArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                int firstNumber = currentArray[0];
                int secondNumber = currentArray[1];

                if (i % 2 == 0)
                {
                    firstArray[i] = firstNumber;
                    secondArray[i] = secondNumber;
                }
                else
                {
                    firstArray[i] = secondNumber;
                    secondArray[i] = firstNumber;
                }

            }

            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write(firstArray[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(string.Join(" ", secondArray));
        }
    }
}
