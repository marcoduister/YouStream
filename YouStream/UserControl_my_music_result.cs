﻿using System;
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
    public partial class UserControl_my_music_result : UserControl
    {
        public UserControl_my_music_result()
        {
            InitializeComponent();
        }

        public string path_video { get; set; }
        
        private void Button_Favorites_Click(object sender, EventArgs e)
        {
            Favorites.FavoritesMT(path_video, Button_Favorites);
        }

        private void UserControl_my_music_result_Load(object sender, EventArgs e)
        {
            Favorites.FavoritesLT(path_video, Button_Favorites);
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            if (Form1.Mp.MusicState != MusicPlayer.musicstate.Waiting)
            {
                Form1.Mp.Stop();
            }

            MusicPlayer.MusicPath = path_video;
            Form1.Mp.StartMusic();
        }
    }
}
