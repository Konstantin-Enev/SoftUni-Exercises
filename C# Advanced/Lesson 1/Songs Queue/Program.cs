using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Queue<string> songs = new Queue<string>(input);

            while (songs.Any())
            {
                string xline = Console.ReadLine();
                if (xline.StartsWith("Add"))
                {
                    string songName = xline.Substring(4);
                    if (songs.Contains(songName))
                    {
                        Console.WriteLine($"{songName} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(songName);
                    }
                }
                else if (xline.StartsWith("Show"))
                {
                    string allSong = string.Join(", ", songs);
                    Console.WriteLine(allSong);
                }
                else if (xline.StartsWith("Play"))
                {
                    songs.Dequeue();
                }

            }

            Console.WriteLine("No more songs!");
        }
    }
}
