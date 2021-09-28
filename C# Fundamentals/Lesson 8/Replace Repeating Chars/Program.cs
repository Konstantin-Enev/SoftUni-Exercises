using System;
using System.Text;
using System.Linq;

namespace Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            //StringBuilder sb = new StringBuilder();

            for(int i = 0; i < input.Length - 1; i++)
            {
                if(input[i] != input[i + 1])
                {
                    Console.Write(input[i]);
                }
            }

            Console.Write(input[input.Length - 1]);
        }
    }
}
