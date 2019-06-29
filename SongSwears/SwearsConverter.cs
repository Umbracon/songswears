using System;
using System.IO;

namespace SongSwears
{
    public class SwearsConverter
    {
        protected string[] badWords;
        public SwearsConverter()
        {
            var profanitiesFile = File.ReadAllText("profanities.txt");
            profanitiesFile = profanitiesFile.Replace("*", "");
            profanitiesFile = profanitiesFile.Replace("(", "");
            profanitiesFile = profanitiesFile.Replace(")", "");
            profanitiesFile = profanitiesFile.Replace("\"", "");
            badWords = profanitiesFile.Split(',');
        }
    }
}
