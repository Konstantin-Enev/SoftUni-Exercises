using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalStudentTickets = 0;
            int totalStandardTickets = 0;
            int totalKidTickets = 0;

            string command = "";

            while (command != "Finish")
            {
                command = Console.ReadLine();

                int student = 0;
                int standard = 0;
                int kid = 0;

                if (command == "Finish")
                {
                    break;
                }

                int freeSeats = int.Parse(Console.ReadLine());

                for (int currentSeat = 1; currentSeat <= freeSeats; currentSeat++)
                {
                    string input = Console.ReadLine();

                    if (input == "student")
                    {
                        student++;
                    }
                    else if (input == "standard")
                    {
                        standard++;
                    }
                    else if (input == "kid")
                    {
                        kid++;
                    }
                    else if (input == "End")
                    {
                        break;
                    }

                }

                totalStudentTickets += student;
                totalStandardTickets += standard;
                totalKidTickets += kid;

                Console.WriteLine($"{command} - {((student * 1.0 + standard + kid) / ((double)freeSeats / 100)):f2}% full.");

            }

            double totalTickets = totalKidTickets + totalStandardTickets + totalStudentTickets;
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(totalStudentTickets/ totalTickets)*100:f2}% student tickets.");
            Console.WriteLine($"{(totalStandardTickets / totalTickets) * 100:f2}% standard tickets.");
            Console.WriteLine($"{(totalKidTickets / totalTickets) * 100:f2}% kids tickets.");

        }
    }
}
