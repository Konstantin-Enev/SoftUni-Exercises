using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int grade = 0;

            double endGrade = 0.0;

            int counter = 0;

            while (grade < 12)
            {
                double currentGrade = double.Parse(Console.ReadLine());

                if (currentGrade < 4)
                {
                    if (counter == 1)
                    {
                        Console.WriteLine($"{name} has been excluded at {grade} grade");
                        break;
                    }
                    counter++;
                }

                endGrade += currentGrade;
                grade++;

            }

            endGrade = endGrade / 12;

            if (grade == 12)
            {
                Console.WriteLine($"{name} graduated. Average grade: {endGrade:f2}");
            }
            

        }
    }
}
