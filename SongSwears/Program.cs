using SearchingCurses;
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
            eminemSwearStats.AddSong("Lose Yourself");
            eminemSwearStats.AddSong("Not Afraid");
            eminemSwearStats.AddSong("The Real Slim Shady");
            eminemSwearStats.AddSong("When I'm Gone");

            var TwoPacStats = new RapperSwearsStats("2Pac");
            TwoPacStats.AddSong("Changes");
            TwoPacStats.AddSong("Dear Mama");
            TwoPacStats.AddSong("Hail Mary");

            var rappers = new List<RapperSwearsStats>();
            rappers.Add(eminemSwearStats);
            rappers.Add(TwoPacStats);

            var unknownSong = new Song("Eminem", "Monster");
            var tinder = new RapperTinder(rappers, unknownSong);

            
            Console.ReadLine();
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