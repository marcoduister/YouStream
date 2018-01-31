using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace YouStream
{
    public partial class UserControl_my_Music : UserControl
    {
        public UserControl_my_Music()
        {
            InitializeComponent();
            
        }


        List<string> list_mymusic = new List<string>();
        public static string path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
        public static string loc = path + "\\youstream\\";
        private void UserControl_my_Music_Load(object sender, EventArgs e)
        {
            int height = 1;
            var list = Directory.GetFiles(loc, "*.Mp3");
            foreach (var video in list)
            {
                list_mymusic.Add(video);
                UserControl_my_music_result music = new UserControl_my_music_result();
                int count = loc.Count();
                string name = video.Remove(0, count);
                music.path_video = video;
                music.label_name_song.Text = name.Remove(name.Length - 4);
                panel_my_music.Controls.Add(music);
                music.Location = new Point(0, height);
                height += 84;
            }
            height = 1;
        }

        private void Button_search_Click(object sender, EventArgs e)
        {
            Lookup();
        }

        List<string> searchresult = new List<string>();
        private void Lookup()
        {
            searchresult.Clear();
            panel_my_music.Controls.Clear();
            DirectoryInfo d = new DirectoryInfo(loc);//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.mp3"); //Getting Text files
            foreach (FileInfo file in Files)
            {
                searchresult.Add(file.Name);
            }
            int height = 1;
            foreach (string result in searchresult)
            {
                if (result.Contains(Textbox_search.Text.ToUpper()) || result.Contains(Textbox_search.Text.ToLower()))
                {
                    UserControl_my_music_result music = new UserControl_my_music_result();
                    music.path_video = loc + result;
                    panel_my_music.Controls.Add(music);
                    int count = loc.Count();
                    music.label_name_song.Text = result.Remove(result.Length - 4);
                    music.Location = new Point(0, height);
                    height += 84;
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

