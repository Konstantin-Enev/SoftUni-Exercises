using System;
using System.Collections.Generic;
using System.Linq;

namespace Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();

            while (true)
            {
                string[] commandArgs = Console.ReadLine().Split(", ").ToArray();
                if (commandArgs[0] == "END")
                {
                    break;
                }
                string direction = commandArgs[0];
                string carNumber = commandArgs[1];

                if (direction == "IN")
                {
                    cars.Add(carNumber);
                }
                else if (direction == "OUT")
                {
                    cars.Remove(carNumber);
                }
            }

            if (cars.Count > 0)
            {
                foreach(var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
