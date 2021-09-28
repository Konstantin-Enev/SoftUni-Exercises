using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            for(int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string name = input[0];
                decimal currentGrade = decimal.Parse(input[1]);

                if (!students.ContainsKey(name))
                {
                    students[name] = new List<decimal>();
                }
                students[name].Add(currentGrade);
            }

            foreach(var student in students)
            {
                var name = student.Key;
                var studentGrades = student.Value;
                var average = studentGrades.Average();

                Console.Write($"{name} -> ");
                foreach(var grade in studentGrades)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {average:f2})");
            }
        }
    }
}
