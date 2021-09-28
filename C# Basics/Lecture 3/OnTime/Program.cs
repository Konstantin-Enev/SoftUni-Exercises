using System;

namespace OnTime
{
    class Program
    {
        static void Main(string[] args)
        {
            int examH = int.Parse(Console.ReadLine());
            int examM = int.Parse(Console.ReadLine());
            int arrivalH = int.Parse(Console.ReadLine());
            int arrivalM = int.Parse(Console.ReadLine());

            int timeStart = 0, timeArrived = 0, timeDifference = 0, outputH = 0, outputM = 0;

            string status = "", output = "";

            timeStart = examH * 60 + examM;
            timeArrived = arrivalH * 60 + arrivalM;

            timeDifference = timeStart - timeArrived;

            if (timeDifference > 30)
            {

                status = "Early";

                if (timeDifference >= 60)
                {
                    outputH = timeDifference / 60;
                    outputM = timeDifference % 60;
                    output = $"{outputH}:{outputM:d2} hours before the start";
                }
                else
                {
                    output = $"{timeDifference} minutes before the start";
                }

            }
            else if (timeDifference < 0)
            {

                status = "Late";
                timeDifference = Math.Abs(timeDifference);


                if (timeDifference >= 60)
                {
                    outputH = timeDifference / 60;
                    outputM = timeDifference % 60;
                    output = $"{outputH}:{outputM:d2} hours after the start";
                }
                else
                {
                    output = $"{timeDifference} minutes after the start";
                }

            }
            else
            {
                status = "On time";
                if (timeDifference > 0)
                {
                    output = $"{timeDifference} minutes before the start";
                }
            }

            Console.WriteLine(status);
            Console.WriteLine(output);

        }
    }
}
