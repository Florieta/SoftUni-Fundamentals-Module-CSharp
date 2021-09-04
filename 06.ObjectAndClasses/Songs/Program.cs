using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < numberSongs; i++)
            {
                string[] song = Console.ReadLine().Split("_");
                Song newSong = new Song();
                newSong.TypeList = song[0];
                newSong.Name = song[1];
                newSong.Time = song[2];
                songs.Add(newSong);
            }

            string filter = Console.ReadLine();
            if (filter == "all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in songs.Where(s => s.TypeList == filter))
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }

    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
