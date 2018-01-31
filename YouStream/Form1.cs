using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace YouStream
{
    public partial class Form1 : Form
    {
        public static MusicPlayer Mp = new MusicPlayer();
        public bool MusicControlOn { get; set; }

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> favlist = Properties.Settings.Default.fav_list.Split(',').ToList();
            Favorites.favoritelist.Clear();
            foreach (string item in favlist)
            {   Favorites.favoritelist.Add(item);   }
            Button_panel_playlist_refresh_Click(null,null);
        }

        #region menu

        private void Button_MyMusic_Click(object sender, EventArgs e)
        {
            UserControl_my_Music change = new UserControl_my_Music();
            Panel(change);
        }

        private void Button_download_Click(object sender, EventArgs e)
        {
            UserControl_Download change = new UserControl_Download();
            Panel(change);
        }

        private void Button_favorites_Click(object sender, EventArgs e)
        {
            UserControl_Favorites change = new UserControl_Favorites();
            Panel(change);
        }

        private void Button_playlists_Click(object sender, EventArgs e)
        {
            UserControl_Playlists change = new UserControl_Playlists();
            Panel(change);
        }

        public void Panel(UserControl change)
        {
            main_panel.Controls.Clear();
            main_panel.Controls.Add(change);
            main_panel.Show();
        }

        #endregion



        #region upperpanel

        public const int WmNclbuttondown = 0xA1;
        public const int HtCaption = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel_upperbar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WmNclbuttondown, HtCaption, 0);
            }
        }

        private void Button_close_Click(object sender, EventArgs e)
        {
            Mp.Stop();
            Application.Exit();
        }

        private void Button_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        #endregion

        public string Temp;
        private void Button_maximize_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach(string item in Favorites.favoritelist)
            {
                if(item == "")
                {      
                }
                else { Temp += item + ","; }
            }
            Properties.Settings.Default.fav_list = Temp;
            Properties.Settings.Default.Save();
        }

        #region playlist

        
        
        private void Button_AddPlaylist_Click(object sender, EventArgs e)
        {
            Button_AddPlaylist.Enabled = false;
            playlist playlistcreate = new playlist(Button_AddPlaylist);
            playlistcreate.Show();
        }

        private int playlist_height = 0;
        private void Button_panel_playlist_refresh_Click(object sender, EventArgs e)
        {
            #region clear variable
            playlist_height = 0;
            panel_playlist.Controls.Clear();
            panel_playlist.Refresh();
            data.playlist_Name_list.Clear();
            data.playlist_Id_list.Clear();
            data.playlist_Description_list.Clear();

            #endregion

            #region start
            data.playlistopvragenbool = true;
            data.Dataget();
            
            #endregion

            foreach( string item in data.playlist_Name_list)
            {
                playlist_litle playlist = new playlist_litle();
                playlist.label_playlist.Text = item;
                panel_playlist.Controls.Add(playlist);
                playlist.Location = new Point(0, playlist_height);
                playlist_height += 46;
            }
        }

        #endregion
    }
}
