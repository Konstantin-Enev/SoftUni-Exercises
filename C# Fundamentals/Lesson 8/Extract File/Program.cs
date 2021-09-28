using System;
using System.Collections.Generic;
using System.Linq;

namespace Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> filepath = Console.ReadLine().Split('\\').ToList();

            foreach(string text in filepath)
            {
                if (text.Contains('.'))
                {
                    string[] textS = text.Split('.');
                    Console.WriteLine($"File name: {textS[0]}");
                    Console.WriteLine($"File extension: {textS[1]}");
                }
            }
        }
    }
}
