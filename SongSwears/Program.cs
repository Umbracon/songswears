using System;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace SongSwears
{
    internal class Program
    {
        public static void Main()
        {

            //var songAnalysis = new SongAnalysis("Kazik", "12 groszy");
            var tekst = "Kurwa, programowanie jest w chuj fajne, no kurwa kurwa!";
            var censor = new Censor();
            Console.WriteLine(censor.Fix(tekst));
            Console.ReadLine();
        }
    }

    class Censor
    {
        string[] badWords;
        public Censor()
        {
            var profanitiesFile = File.ReadAllText("profanities.txt");
            profanitiesFile = profanitiesFile.Replace("*", "");
            profanitiesFile = profanitiesFile.Replace("(", "");
            profanitiesFile = profanitiesFile.Replace(")", "");
            profanitiesFile = profanitiesFile.Replace("\"", "");
            badWords = profanitiesFile.Split(',');
        }

        internal string Fix(string tekst)
        {
            foreach (var word in badWords)
            {
                tekst = ReplaceBadWord(tekst, word);
            }
            return tekst;
        }

        private static string ReplaceBadWord(string tekst, string word)
        {
            var pattern = "\\b" + word + "\\b";
            return Regex.Replace(tekst, pattern, "______", RegexOptions.IgnoreCase);
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

    public class LyricsovhAnswer
    {
        public string lyrics;
        public string error;
    }
}