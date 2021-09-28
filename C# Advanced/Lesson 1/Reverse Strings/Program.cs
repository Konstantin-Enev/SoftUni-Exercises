using System;
using System.Collections.Generic;

namespace Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> outputString = new Stack<char>();

            foreach(char ch in input)
            {
                outputString.Push(ch);
            }

            while(outputString.Count != 0)
            {
                Console.Write(outputString.Pop());
            }
            Console.WriteLine();
        }
    }
}
