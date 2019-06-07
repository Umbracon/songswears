using System.Net;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace SongSwears
{
    public class Song
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
}