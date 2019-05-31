using System;
using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace SongSwears
{
    internal class Program
    {
        static void Main()
        {
            var eminemSwearStats = new SwearStats();
            var song = new Song("Eminem", "Stan");
            eminemSwearStats.AddSwearsFrom(song);
            //var censor = new Censor();
            //Console.WriteLine(censor.Fix(song.lyrics));
            Console.ReadLine();
        }
    }

    class SwearStats:Censor
    {
        Dictionary<string, int> allSwears = new Dictionary<string, int>();
        public SwearStats()
        {

        }

        public void AddSwearsFrom(Song song)
        {
            foreach (var word in badWords)
            {
                var occurrences = song.CountOccurrence(word);
            }
        }
    }

    class Song
    {
        public string title;
        public string artist;
        public string lyrics;

        public Song(string band, string songName)
        {
            var browser = new WebClient();
            var url = "https://api.lyrics.ovh/v1/" + band + "/" + songName;
            var json = browser.DownloadString(url);
            var lyricsData = JsonConvert.DeserializeObject<LyricsovhAnswer>(json);

            title = songName;
            artist = band;
            lyrics = lyricsData.lyrics;
        }

        public int CountOccurrence(string word)
        {
            var pattern = "\\b" + word + "\\b";
            return Regex.Matches(lyrics, pattern, RegexOptions.IgnoreCase).Count;
        }
    }

    class LyricsovhAnswer
    {
        public string lyrics;
        public string error;
    }
}