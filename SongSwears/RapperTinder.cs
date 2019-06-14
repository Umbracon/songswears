using System;
using System.Collections.Generic;

namespace SongSwears
{
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
}