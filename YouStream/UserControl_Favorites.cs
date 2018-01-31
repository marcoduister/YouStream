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
    public partial class UserControl_Favorites : UserControl
    {
        public UserControl_Favorites()
        {
            InitializeComponent();
        }

        public int height;
        private void UserControl_Favorites_Load(object sender, EventArgs e)
        {
            foreach( string item in Favorites.favoritelist)
            {
                if(item!="")
                {
                    UserControl_my_music_result music = new UserControl_my_music_result();
                    int count = UserControl_my_Music.loc.Count();
                    string name = item.Remove(0, count);
                    music.label_name_song.Text = name.Remove(name.Length - 4);
                    music.path_video = item;
                    panel_video.Controls.Add(music);
                    music.Location = new Point(0, height);
                    height += 84;
                }
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            Lookup();
        }

        private void Lookup()
        {
            height = 0;
            panel_video.Controls.Clear();
            
            foreach (string result in Favorites.favoritelist)
            {
                if (result != "")
                {
                    if (result.Contains(Textbox_search.Text.ToUpper()) || result.Contains(Textbox_search.Text.ToLower()))
                    {
                        UserControl_my_music_result music = new UserControl_my_music_result();
                        int count = UserControl_my_Music.loc.Count();
                        string name = result.Remove(0, count);
                        music.label_name_song.Text = name.Remove(name.Length - 4);
                        music.path_video = result;
                        panel_video.Controls.Add(music);
                        music.Location = new Point(0, height);
                        height += 84;
                    }
                }
            }
        }

        private void Textbox_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                Lookup();
            }
        }
    }
}
