using System;

namespace OperationsNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();

            double result = 0;

            switch (symbol)
            {
                case "+":
                    result = n1 + n2;
                    if(result % 2 == 0)
                    {
                        Console.WriteLine($"{n1} + {n2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} + {n2} = {result} - odd");
                    }
                    break;
                case "-":
                    result = n1 - n2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{n1} - {n2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} - {n2} = {result} - odd");
                    }
                    break;
                case "*":
                    result = n1 * n2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{n1} * {n2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} * {n2} = {result} - odd");
                    }
                    break;
                case "/":
                    if(n2 != 0)
                    {
                        result = n1 / ( n2 * 1.00);
                        Console.WriteLine($"{n1} / {n2} = {result:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    break;
                case "%":
                    if (n2 != 0)
                    {
                        result = n1 % n2;
                        Console.WriteLine($"{n1} % {n2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    break;
            }

        }
    }
}
