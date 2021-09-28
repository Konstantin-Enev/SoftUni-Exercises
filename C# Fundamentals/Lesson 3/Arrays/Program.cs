using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = new string[7];

            daysOfWeek[0] = "Monday";
            daysOfWeek[1] = "Tuesday";
            daysOfWeek[2] = "Wednesday";
            daysOfWeek[3] = "Thursday";
            daysOfWeek[4] = "Friday";
            daysOfWeek[5] = "Saturday";
            daysOfWeek[6] = "Sunday";

            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine(daysOfWeek[0]);
                    break;
                case 2:
                    Console.WriteLine(daysOfWeek[1]);
                    break;
                case 3:
                    Console.WriteLine(daysOfWeek[2]);
                    break;
                case 4:
                    Console.WriteLine(daysOfWeek[3]);
                    break;
                case 5:
                    Console.WriteLine(daysOfWeek[4]);
                    break;
                case 6:
                    Console.WriteLine(daysOfWeek[5]);
                    break;
                case 7:
                    Console.WriteLine(daysOfWeek[6]);
                    break;
                default:
                    Console.WriteLine("Invalid day!");
                    break;
            }

        }
    }
}
