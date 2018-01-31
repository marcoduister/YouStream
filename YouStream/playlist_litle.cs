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
    public partial class playlist_litle : UserControl
    {

        public Panel main;
        public string Playlist_name { get; set; }
        public int Playlist_id { get; set; }
        public string Playlist_Description { get; set; }

        public playlist_litle(Panel main)
        {
            this.main = main;
            InitializeComponent();
        }

        private void button_playlist_open_Click(object sender, EventArgs e)
        {
            main.Controls.Clear();
            UserControl_Playlists change = new UserControl_Playlists();
            main.Controls.Add(change);

            main.Show();

        }

    }
}
