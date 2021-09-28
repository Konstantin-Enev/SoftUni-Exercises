using System;
using System.Collections.Generic;
using System.Linq;

namespace Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Stack<int> indices = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    indices.Push(i);
                }
                else if (expression[i] == ')')
                {
                    var openBracketIndex = indices.Pop();
                    var closedBracketIndex = i;

                    Console.WriteLine(expression.Substring(openBracketIndex, closedBracketIndex - openBracketIndex + 1));
                }
            }
        }
    }
}
