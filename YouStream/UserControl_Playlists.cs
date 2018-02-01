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
    public partial class UserControl_Playlists : UserControl
    {
        public int Playlist_id { get; set; }
        public UserControl_Playlists()
        {
            InitializeComponent();
        }

        private void UserControl_Playlists_Load(object sender, EventArgs e)
        {
            
            Fill();
        }

        private int height = 0;
        private int count_item = 0;
        private void Fill()
        {
            #region clear variable
            height = 0;
            data.song_Id_list.Clear();
            data.song_Name_list.Clear();
            data.song_path_list.Clear();
            count_item = 0;

            #endregion

            #region start

            data.Playlist_idget = Playlist_id;
            data.songopvragenbool = true;
            data.Dataget();

            #endregion

            foreach (string item in data.song_Name_list)
            {
                UserControl_playlistresults playlisttemp = new UserControl_playlistresults();
                playlisttemp.label_song_name.Text = item;
                playlisttemp.Playlist_id = Playlist_id;
                playlisttemp.Name = data.song_Name_list[count_item];
                playlisttemp.Path = data.song_path_list[count_item];
                playlisttemp.Playlist_song_Id = data.song_Id_list[count_item];
                panel_songs.Controls.Add(playlisttemp);
                playlisttemp.Location = new Point(0, height);
                height += 50;
                count_item += 1;
            }
        }

        
        private void Button_add_song_Click(object sender, EventArgs e)
        {


 
        }
    }
}
