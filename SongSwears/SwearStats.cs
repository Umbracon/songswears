using System;
using System.Collections.Generic;

namespace SongSwears
{
    public class SwearStats : SwearsConverter
    {
        Dictionary<string, int> allSwears = new Dictionary<string, int>();

        public void AddSwears(Song song)
        {
            foreach (var swear in badWords)
            {
                var occurrences = song.CountOccurrence(swear);
                if (occurrences > 0)
                { 
                    if (!allSwears.ContainsKey(swear))
                        allSwears.Add(swear, 0);
                    allSwears[swear] += occurrences;
                }
            }
        }

        public void ShowSummary()
        {
            foreach (var item in allSwears)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }
        }

        public int FindCommonSwearsScore(SwearStats anotherStats)
        {
            int score = 0;
            foreach (var myWord in allSwears)
            {
                if (anotherStats.allSwears.ContainsKey(myWord.Key))
                    score++;
            }
            return score;
        }
    }
}