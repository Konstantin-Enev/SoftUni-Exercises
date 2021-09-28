using System;
using System.Linq;

namespace Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            #region my_Code
            /*
                int size = int.Parse(Console.ReadLine());

                char[,] matrix = new char[size, size];

                for (int r = 0; r < matrix.GetLength(0); r++)
                {
                    string elements = Console.ReadLine();

                    for (int c = 0; c < matrix.GetLength(1); c++)
                    {
                        matrix[r, c] = elements[c];
                    }
                }

                char chToLookFor = char.Parse(Console.ReadLine());
                bool chFound = false;

                for (int r = 0; r < matrix.GetLength(0); r++)
                {
                    for (int c = 0; c < matrix.GetLength(1); c++)
                    {
                        if (matrix[r, c] == chToLookFor)
                        {
                            Console.WriteLine($"({r}, {c})");
                            chFound = true;
                            break;
                        }
                    }
                }

                if(chFound == false)
                {
                    Console.WriteLine($"{chToLookFor} does not occur in the matrix");
                }
                */ 
            #endregion
            var number = int.Parse(Console.ReadLine());
            string index = String.Empty;
            var matrix = new char[number][];
            bool found = false;
            for (int i = 0; i < number; i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray();
            }

            char searched = char.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                if (matrix[i].Contains(searched))
                {
                    found = true;
                    int indexOfRow = new string(matrix[i]).IndexOf(searched);
                    index = $"({i}, {indexOfRow})";
                    break;
                }
            }
            string resultNegative = $"{searched} does not occur in the matrix";
            Console.WriteLine(found ? index : resultNegative);
        }
    }
}
