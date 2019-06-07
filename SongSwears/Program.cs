using System;
using System.Collections.Generic;

namespace SongSwears
{
    internal class Program
    {
        static void Main()
        {
            var eminemSwearStats = new RapperSwearsStats("Eminem");
            eminemSwearStats.AddSong("Stan");

            var TwoPacStats = new RapperSwearsStats("2Pac");
            TwoPacStats.AddSong("Changes");

            var rappers = new List<RapperSwearsStats>();
            rappers.Add(eminemSwearStats);
            rappers.Add(TwoPacStats);

            var unknownSong = new Song("Eminem", "Monster");
            var tinder = new RapperTinder(rappers, unknownSong);

            Console.ReadLine();
        }
    }

    internal class RapperTinder
    {
        private List<RapperSwearsStats> rappers;
        private Song unknownSong;

        public RapperTinder(List<RapperSwearsStats> rappers, Song unknownSong)
        {
            this.rappers = rappers;
            this.unknownSong = unknownSong;

            var songSwearStats = new SwearStats();
            songSwearStats.AddSwearsFrom(unknownSong);

            foreach (var rapper in rappers)
            {
                var score = rapper.FindCommonSwearsScore(songSwearStats);
                Console.WriteLine(rapper.name + ": " + score + " points.");
            }
        }
    }

    public class RapperSwearsStats : SwearStats
    {
        public string name;
        public RapperSwearsStats(string name) => this.name = name;

        public void AddSong(string title)
        {
            var song = new Song(name, title);
            AddSwearsFrom(song);
        }
    }
}