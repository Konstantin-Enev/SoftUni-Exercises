using System;
using System.Collections.Generic;
using System.Linq;

namespace Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Stack<char> bracketsStack = new Stack<char>();

            foreach (var symbol in expression)
            {
                if (bracketsStack.Any())
                {
                    char check = bracketsStack.Peek();
                    if (check == '{' && symbol == '}')
                    {
                        bracketsStack.Pop();
                        continue;
                    }
                    else if (check == '[' && symbol == ']')
                    {
                        bracketsStack.Pop();
                        continue;
                    }
                    else if (check == '(' && symbol == ')')
                    {
                        bracketsStack.Pop();
                        continue;
                    }
                }

                bracketsStack.Push(symbol);
            }

            Console.WriteLine(!bracketsStack.Any() ? "YES": "NO");
        }
    }
}
