using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsAndLinqExercises
{
    class Song
    {
        public string Artist { get; set; }
        public string Name { get; set; }

        public Song(string artist, string name)
        {
            Artist = artist;
            Name = name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var goodSongs = new List<Song>();
            var allSongs = new List<Song>()
            {
                new Song("Grimes", "Delete Forever"),
                new Song("Freddy Cole", "My Mood Is You"),
                new Song("Daft Punk", "Fragments of Time"),
                new Song("Charley Crockett", "In the Night"),
                new Song("Creed", "Supposedly Bad Song"),
                new Song("Creed", "Another Supposedly Bad Song"),
                new Song("Sun Ra", "Enlightenment"),
                new Song("Maluma", "Hawai"),
                new Song("She & Him", "Sentimental Heart"),
                new Song("Fleetwood Mac", "Dreams"),
                new Song("Jason Mraz", "Disco Sun"),
                new Song("Grimes", "Sardaukar Levenbrech")
            };
            var notCreed = allSongs.Where(song => song.Artist != "Creed");
            foreach (var song in notCreed)
            {
                goodSongs.Add(song);
            }
            foreach (var song in goodSongs)
            {
                Console.WriteLine($"{song.Artist} : {song.Name}");
            }
        }
    }
}
