using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> elements = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] bombInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bombNumber = bombInput[0];
            int bombStrenght = bombInput[1];

            for (int i = 0; i < elements.Count; i++)
            {
                if(elements[i] == bombNumber)
                {
                    int start = i - bombStrenght;
                    //
                    if(start <0)
                    {
                        start = 0;
                    }

                    int finish = i + bombStrenght + 1;
                    //
                    if(finish > elements.Count)
                    {
                        finish = elements.Count;
                    }

                    for (int j = start; j < finish; j++)
                    {
                        elements[j] = 0;
                    }
                }
            }

            Console.WriteLine(elements.Sum());
        }
    }
}
