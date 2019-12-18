using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Problem_6._Songs_Queue
{
    class Program
    {
        static void Main()
        {
            string[] songs = Console.ReadLine()
                .Split(", ")
                .ToArray();
            Queue<string> queueOfSongs = new Queue<string>();

            for (int i = 0; i < songs.Length; i++)
            {
                queueOfSongs.Enqueue(songs[i]);
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Play")
                {
                    queueOfSongs.Dequeue();
                    if (queueOfSongs.Count == 0)
                    {
                        Console.WriteLine("No more songs!");
                        break;
                    }
                }
                else if (command == "Show")
                {
                    var songsToPrint = new List<string>();
                    foreach (var song in queueOfSongs)
                    {
                        songsToPrint.Add(song);
                    }


                    Console.WriteLine(string.Join(", ", songsToPrint));
                }
                else
                {
                    string[] songToAdd = command.Split();
                    string song = string.Empty;
                    for (int i = 1; i < songToAdd.Length; i++)
                    {
                        if (i + 1 == songToAdd.Length)
                        {
                            song += songToAdd[i];
                        }
                        else
                        {
                            song += songToAdd[i] + " ";
                        }
                    }
                    song.Trim();
                    if (!queueOfSongs.Contains(song))
                    {
                        queueOfSongs.Enqueue(song);
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }
            }


        }
    }
}
