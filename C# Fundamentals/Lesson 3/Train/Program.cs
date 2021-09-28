using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());

            int[] peopleInTrain = new int[wagons];
            int sum = 0;

            for(int i = 0; i < wagons; i++)
            {
                int numberOfPeople = int.Parse(Console.ReadLine());

                peopleInTrain[i] = numberOfPeople;
                sum += numberOfPeople;

            }

            for(int i = 0; i < wagons; i++)
            {
                Console.Write(peopleInTrain[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);

        }
    }
}
