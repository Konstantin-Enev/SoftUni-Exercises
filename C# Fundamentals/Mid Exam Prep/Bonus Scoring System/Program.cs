using System;
using System.Collections.Generic;
using System.Linq;

namespace Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentCount = int.Parse(Console.ReadLine());
            int lectureCount = int.Parse(Console.ReadLine());
            int initialBonus = int.Parse(Console.ReadLine());

            double maxBonus = 0;
            double maxStudentAttendance = 0;

            for (int i = 0; i < studentCount; i++)
            {
                int studentAttendance = int.Parse(Console.ReadLine());

                double totalBonus = (double)studentAttendance / lectureCount * (5 + initialBonus);

                if (totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                    maxStudentAttendance = studentAttendance;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {Math.Ceiling(maxStudentAttendance)} lectures.");
        }
    }
}
