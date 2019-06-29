using System;
using System.Windows.Forms;

namespace SongSwears
{
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();
        }
     
        private void Run_Click(object sender, EventArgs e)
        {
            var insertedLyrics = lyrics.Text;
            var junction = new SimilitudeFinder(Program.artistsLyrics, insertedLyrics);

            if (lyrics.Text == "")
            {
                artist.Text = "There are no lyrics :(";
            }
            else
            {
                artist.Text = junction.winner;
            }
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
