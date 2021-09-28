﻿using System;
using System.Text;
using System.Linq;

namespace String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder(input);
            int counter = 0;
            int reminder = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if(input[i] == '>')
                {
                    int power = int.Parse(input[i + 1].ToString()) + reminder;
                    int leftPower = power;
                    bool shouldReset = true;

                    for(int j = i + 1; j < i + 1 + power && j < input.Length; j++)
                    {
                        if(input[j] == '>')
                        {
                            reminder = leftPower;
                            shouldReset = false;
                            break;
                        }

                        sb.Remove(j - counter, 1);
                        leftPower--;
                        counter++;

                        //video at -42:37
                        //abv>1>1>2>2asdasd
                    }

                    if (shouldReset)
                    {
                        reminder = 0;
                    }
                }
            }

            Console.WriteLine(sb);
        }
    }
}
