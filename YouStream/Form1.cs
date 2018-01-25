using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace YouStream
{
    public partial class Form1 : Form
    {
        public static string MusicPath { get; set; }
        public musicstate MusicState { get; set; }
        public FileStream ms { get; set; }
        public Mp3FileReader rdr { get; set; }
        public WaveStream wavStream { get; set; }
        public BlockAlignReductionStream _barStream { get; set; }
        public WaveOut waveOut { get; set; }


        public Form1()
        {
            InitializeComponent();

            var file = $"{Path.GetTempPath()}emptyMP3.mp3";
            if (!File.Exists(file))
            {
                using (Stream output = new FileStream(file, FileMode.Create))
                {
                    output.Write(Properties.Resources.YouStream_Empty_Mp3, 0, Properties.Resources.YouStream_Empty_Mp3.Length);
                }
            }
            ms = File.OpenRead($"{Path.GetTempPath()}emptyMP3.mp3");
            rdr = new Mp3FileReader(ms);
            wavStream = WaveFormatConversionStream.CreatePcmStream(rdr);
            _barStream = new BlockAlignReductionStream(wavStream);
            waveOut = new WaveOut(WaveCallbackInfo.FunctionCallback());
            waveOut.Init(_barStream);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> favlist = Properties.Settings.Default.fav_list.Split(',').ToList();
            Favorites.favoritelist.Clear();
            foreach (string item in favlist)
            {   Favorites.favoritelist.Add(item);   }
        }

        #region menu

        private void Button_MyMusic_Click(object sender, EventArgs e)
        {
            UserControl_my_Music change = new UserControl_my_Music();
            Panel(change);
        }

        private void Button_RecentlyPlayed_Click(object sender, EventArgs e)
        {
            UserControl_Recently_played change = new UserControl_Recently_played();
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

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel_upperbar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        #endregion

        public string temp;
        private void Button_maximize_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach(string item in Favorites.favoritelist)
            {
                if(item == "")
                {      
                }
                else { temp += item + ","; }
            }
            Properties.Settings.Default.fav_list = temp;
            Properties.Settings.Default.Save();
        }

        #region Music Control Methodes

        public void StartMusic()
        {
            ms = File.OpenRead(MusicPath);
            rdr = new Mp3FileReader(ms);
            wavStream = WaveFormatConversionStream.CreatePcmStream(rdr);
            _barStream = new BlockAlignReductionStream(wavStream);
            waveOut.Init(_barStream); 

            waveOut.Stop();
            rdr.Position = 0;
            waveOut.Play();
            MusicState = musicstate.Playing;
        }

        #endregion

        public enum musicstate
        {
            Playing,
            Paused,
            Stopped
        }
    }
}
