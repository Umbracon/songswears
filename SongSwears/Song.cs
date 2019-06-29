using Newtonsoft.Json;
using SearchingCurses;
using System.Text.RegularExpressions;

namespace SongSwears
{
    public class Song
    {
        public string title;
        public string artist;
        public string lyrics;
        public Song(string artistName, string songName)
        {
            var url = "https://api.lyrics.ovh/v1/" + artistName + "/" + songName;
            var json = WebCache.GetOrDownload(url);
            var lyricsData = JsonConvert.DeserializeObject<ApiAnswer>(json);

            title = songName;
            artist = artistName;
            lyrics = lyricsData.lyrics;

        }
        public int CountOccurrence(string word)
        {
            var pattern = "\\b" + word + "\\b";
            return Regex.Matches(lyrics, pattern, RegexOptions.IgnoreCase).Count;
        }
        public void AddLyrics(string insertedLyrics)
        {
            lyrics = insertedLyrics;
        }
    }
}