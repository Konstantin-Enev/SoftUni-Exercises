using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Stack<string> stringStates = new Stack<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cline = Console.ReadLine().Split();

                if (cline[0] == "1")
                {
                    stringStates.Push(sb.ToString());

                    string value = cline[1];

                    sb.Append(value);
                }
                else if (cline[0] == "2")
                {
                    stringStates.Push(sb.ToString());

                    int count = int.Parse(cline[1]);

                    while (count > 0)
                    {
                        sb.Remove(sb.Length - 1, 1);
                        count--;
                    }
                }
                else if (cline[0] == "3")
                {
                    int elementsNumber = int.Parse(cline[1]);

                    Console.WriteLine(sb[elementsNumber - 1]);
                }
                else if (cline[0] == "4")
                {
                    sb.Clear();
                    sb.Append(stringStates.Pop());
                }
            }
        }
    }
}
