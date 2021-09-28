using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double GPA = double.Parse(Console.ReadLine());
            double minimalIncome = double.Parse(Console.ReadLine());

            double socialSp = Math.Floor(0.35 * minimalIncome);
            double excellentSp = Math.Floor(GPA * 25);

            if(income < minimalIncome && GPA >= 5.50)
            {
                if(socialSp > excellentSp)
                {
                    Console.WriteLine($"You get a Social scholarship {socialSp} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {excellentSp} BGN");
                }
            }
            else if (income < minimalIncome && GPA >= 4.50)
            {
                Console.WriteLine($"You get a Social scholarship {socialSp} BGN");
            }
            else if(GPA >= 5.50)
            {
                Console.WriteLine($"You get a scholarship for excellent results {excellentSp} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }

        }
    }
}
