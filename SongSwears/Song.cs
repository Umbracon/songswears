using System.Net;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using SearchingCurses;

namespace SongSwears
{
    public class Song
    {
        public string title;
        public string artist;
        public string lyrics;

        public Song(string band, string songName)
        {
            var url = "https://api.lyrics.ovh/v1/" + band + "/" + songName;
            var json = WebCache.GetOrDownload(url);
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
}