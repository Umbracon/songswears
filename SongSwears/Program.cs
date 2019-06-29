using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SongSwears
{
    static class Program
    {
        public static List<ArtistSwearStats> artistsLyrics;

        [STAThread]

        static void Main()
        {
            var iggyAzaleaStats = new ArtistSwearStats("Iggy Azalea");
            iggyAzaleaStats.AddSong("Mo Bounce");
            iggyAzaleaStats.AddSong("Fancy");
            iggyAzaleaStats.AddSong("Black Widow");
            iggyAzaleaStats.AddSong("Kream");
            iggyAzaleaStats.AddSong("Bounce");
            iggyAzaleaStats.AddSong("Pretty Girls");
            iggyAzaleaStats.AddSong("Work");
            iggyAzaleaStats.AddSong("Sally Walker");
            iggyAzaleaStats.AddSong("Savior");
            iggyAzaleaStats.AddSong("Started");

            var nickiMinajStats = new ArtistSwearStats("Nicki Minaj");
            nickiMinajStats.AddSong("Anaconda");
            nickiMinajStats.AddSong("Starships");
            nickiMinajStats.AddSong("Va Va Voom");
            nickiMinajStats.AddSong("Bang Bang");
            nickiMinajStats.AddSong("Super Bass");
            nickiMinajStats.AddSong("Chun-Li");
            nickiMinajStats.AddSong("Pound The Alarm");
            nickiMinajStats.AddSong("No Frauds");
            nickiMinajStats.AddSong("Barbie Dreams");
            nickiMinajStats.AddSong("Megatron");

            var cupcakKeStats = new ArtistSwearStats("cupcakKe");
            cupcakKeStats.AddSong("Deepthroat");
            cupcakKeStats.AddSong("Lgbt");
            cupcakKeStats.AddSong("Squidward Nose");
            cupcakKeStats.AddSong("Quiz");
            cupcakKeStats.AddSong("Bird Box");
            cupcakKeStats.AddSong("Spider-Man Dick");
            cupcakKeStats.AddSong("Vagina");
            cupcakKeStats.AddSong("Pedophile");
            cupcakKeStats.AddSong("Duck Duck Goose");
            cupcakKeStats.AddSong("Spoiled Milk Titties");

            var sakimaStats = new ArtistSwearStats("SAKIMA");
            sakimaStats.AddSong("Daddy");
            sakimaStats.AddSong("Apps");
            sakimaStats.AddSong("Polari");
            sakimaStats.AddSong("Holy Water");
            sakimaStats.AddSong("All Your Secrets");
            sakimaStats.AddSong("He's Trippi");
            sakimaStats.AddSong("What I Know Now");
            sakimaStats.AddSong("I Used to Have an en Suite");
            sakimaStats.AddSong("Snake Boy City");
            sakimaStats.AddSong("Happy Hr");

            var alaskaThunderfuckStats = new ArtistSwearStats("Alaska Thunderfuck");
            alaskaThunderfuckStats.AddSong("Puppet");
            alaskaThunderfuckStats.AddSong("Vagina");
            alaskaThunderfuckStats.AddSong("Cellulite");
            alaskaThunderfuckStats.AddSong("Nails");
            alaskaThunderfuckStats.AddSong("Getting Kicked out (Of Micky's on a Sunday Night)");
            alaskaThunderfuckStats.AddSong("Snaked");
            alaskaThunderfuckStats.AddSong("Hieeee");
            alaskaThunderfuckStats.AddSong("Slaytina");
            alaskaThunderfuckStats.AddSong("This Is My Hair");
            alaskaThunderfuckStats.AddSong("Come to Brazil");

            artistsLyrics = new List<ArtistSwearStats>();
            artistsLyrics.Add(iggyAzaleaStats);
            artistsLyrics.Add(nickiMinajStats);
            artistsLyrics.Add(cupcakKeStats);
            artistsLyrics.Add(sakimaStats);
            artistsLyrics.Add(alaskaThunderfuckStats);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AppForm());
        }
    }
}
