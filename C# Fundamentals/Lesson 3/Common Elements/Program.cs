using System;

namespace Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split(' ');
            string[] secondInput = Console.ReadLine().Split(' ');


            for (int i = 0; i < secondInput.Length; i++)
            {
                string currentElement = secondInput[i];

                for (int j = 0; j < firstInput.Length; j++)
                {
                    if(currentElement == firstInput[j])
                    {
                        Console.Write(currentElement + " ");
                    }
                }

            }

        }
    }
}
