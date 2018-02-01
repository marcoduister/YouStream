using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouStream
{

    public partial class UserControl_playlistresults : UserControl
    {
        public int Playlist_id { get; set; }
        public string Path { get; set; }
        public new string Name { get; set; }
        public int Playlist_song_Id { get; set; }

        public UserControl_playlistresults()
        {
            InitializeComponent();
        }
    
        private void button_play_Click(object sender, EventArgs e)
        {
            if (Form1.Mp.MusicState != MusicPlayer.musicstate.Waiting)
            {
                Form1.Mp.Stop();
            }

            MusicPlayer.MusicPath = Path;
            Form1.Mp.StartMusic();

        }
    }
    
}
