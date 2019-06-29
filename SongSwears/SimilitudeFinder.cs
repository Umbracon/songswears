using System.Collections.Generic;

namespace SongSwears
{
    public class SimilitudeFinder
    {
        private List<ArtistSwearStats> artistsLyrics;
        private string insertedLyrics;
        public int maxScore = 0;
        public string winner = "";
        public SimilitudeFinder(List<ArtistSwearStats> artistsLyrics, string insertedLyrics)
        {
            this.artistsLyrics = artistsLyrics;
            this.insertedLyrics = insertedLyrics;
            var songSwearStats = new SwearStats();
            var unknownSong = new Song("unknown", "unknown");
            unknownSong.AddLyrics(insertedLyrics);
            songSwearStats.AddSwears(unknownSong);

            foreach (var artist in artistsLyrics)
            {
                var score = artist.FindCommonSwearsScore(songSwearStats);
                if (score >= maxScore)
                {
                    maxScore = score;
                    winner = artist.artistName;
                }
            }
        }
    }
}