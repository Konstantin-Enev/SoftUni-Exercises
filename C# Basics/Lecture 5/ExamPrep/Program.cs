using System;

namespace ExamPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGradeCounter = int.Parse(Console.ReadLine());

            double scoreAvrg = 0.0;
            int problemsCounter = 0;
            string problemName = "";
            int badGradeAmount = 0;

            string input = Console.ReadLine();

            while (input != "Enough")
            {
                problemName = input;
                double currentScore = double.Parse(Console.ReadLine());
                problemsCounter++;

                if(currentScore <= 4.0)
                {
                    badGradeAmount++;
                    if (badGradeAmount >= badGradeCounter)
                    {
                        break;
                    }
                }

                scoreAvrg += currentScore;

                input = Console.ReadLine();
            }

            if(badGradeAmount >= badGradeCounter)
            {
                Console.WriteLine($"You need a break, {badGradeAmount} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {(scoreAvrg/problemsCounter):f2}");
                Console.WriteLine($"Number of problems: {problemsCounter}");
                Console.WriteLine($"Last problem: {problemName}");
            }

        }
    }
}
