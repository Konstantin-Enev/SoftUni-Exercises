using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            List<Student> listOfStudents = new List<Student>();

            for (int i = 0; i < counter; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                Student currentStudent = new Student();
                currentStudent.FirstName = input[0];
                currentStudent.LastName = input[1];
                currentStudent.Grade = double.Parse(input[2]);

                listOfStudents.Add(currentStudent);
            }

            listOfStudents.OrderByDescending(t => t.Grade).ThenBy(t => t.FirstName).ToList();
            List<Student> sortedStudents = listOfStudents.OrderByDescending(t => t.Grade).ThenBy(t => t.FirstName).ThenBy(t => t.LastName).ToList();

            foreach (Student t in sortedStudents)
            {
                Console.WriteLine($"{t.FirstName} {t.LastName}: {t.Grade:f2}");
            }
        }
    }

    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade}";
        }
    }
}
