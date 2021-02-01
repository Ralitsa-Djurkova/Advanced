using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songsName = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Queue<string> songs = new Queue<string>(songsName);
            string command = Console.ReadLine();

            while (songs.Count > 0)
            {
               
                if (command.Contains("Play"))
                {
                    songs.Dequeue();
                }
                else if(command.Contains("Add"))
                {
                    var songToAdd = command.Split("Add ");
                    if (!songs.Contains(songToAdd[1]))
                    {
                        songs.Enqueue(songToAdd[1]);
                    }
                    else
                    {
                        Console.WriteLine($"{songToAdd[1]} is already contained!");
                    }
                }
                else if(command.Contains("Show"))
                {
                    Console.WriteLine(string.Join(", ",songs));
                }
               
                command = Console.ReadLine();
            }
            if (songs.Count == 0)
            {
                Console.WriteLine("No more songs!");

            }

        }
    }
}
