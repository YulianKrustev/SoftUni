using System;
using System.Collections.Generic;

namespace Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Queue<string> songList = new Queue<string>(songs);

            while (songList.Count > 0)
            {
                string command = Console.ReadLine();

                if (command.StartsWith("Add"))
                {
                    string songName = command.Substring(4);

                    if (songList.Contains(songName))
                    {
                        Console.WriteLine($"{songName} is already contained!");
                    }
                    else
                    {
                        songList.Enqueue(songName);
                    }
                }
                else if (command == "Play") 
                {
                    songList.Dequeue();
                }
                else
                {
                    Console.WriteLine(string.Join(", ", songList));
                }

            }

            Console.WriteLine("No more songs!");
        }
    }
}
