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
        private void UserControl_my_Music_Load(object sender, EventArgs e)
        {
            //System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"");

            
            int height = 0;
            var list = Directory.GetFiles(@"D:\marco\Music\youstream", "*.Mp3");
            foreach (var video in list)
            {
                list_mymusic.Add(video);
            }
            foreach (string item in list)
            {
                UserControl_my_music_result panel_mymusic = new UserControl_my_music_result();
                panel_my_music.Controls.Add(panel_mymusic);
                height += 76;
                panel_my_music.Location = new Point(0, height);

            }

        }
    }
}
