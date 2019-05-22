using System;
using System.Net;

namespace SongSwears
{
    internal class Program
    {
        public static void Main()
        {
            var songAnalysis = new SongAnalysis("Kazik", "12 groszy");
            Console.ReadLine();
        }
    }

    class SongAnalysis
    {
        public SongAnalysis(string band, string song)
        {
            var browser = new WebClient();
            var url = "https://api.lyrics.ovh/v1/" + band + "/" + song;
            var json = browser.DownloadString(url);
            Console.WriteLine(json);
        }
    }
}
   