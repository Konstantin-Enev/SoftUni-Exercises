﻿using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for(int i = 0; i < n; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                sum += num1;
            }

            Console.WriteLine(sum);
        }
    }
}
