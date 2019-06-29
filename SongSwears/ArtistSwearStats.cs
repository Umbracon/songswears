namespace SongSwears
{
    public class ArtistSwearStats : SwearStats
    {
        public string artistName;
        public ArtistSwearStats(string artistName)
        {
            this.artistName = artistName;
        }

        public void AddSong(string songName)
        {
            var song = new Song(artistName, songName);

            AddSwears(song);
        }
    }
}