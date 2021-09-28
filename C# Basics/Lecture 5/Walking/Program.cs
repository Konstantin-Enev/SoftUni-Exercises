using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int goal = 10000;

            int stepCounter = 0;


            while (stepCounter < goal)
            {
                string input = Console.ReadLine();

                if (input == "Going home")
                {
                    stepCounter += int.Parse(Console.ReadLine());
                    break;
                }
                stepCounter += int.Parse(input);

            }

            if(stepCounter < goal)
            {
                Console.WriteLine($"{goal - stepCounter} more steps to reach goal.");
            }
            else
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{stepCounter - goal} steps over the goal!");
            }

        }
    }
}
