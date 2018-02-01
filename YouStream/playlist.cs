using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using System.Threading;

namespace YouStream
{
    public partial class playlist : Form
    {
        private BunifuImageButton buttonactive;
        

        public playlist(BunifuImageButton buttonactive)
        {
            this.buttonactive = buttonactive;
            
            InitializeComponent();
        }

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
            buttonactive.Enabled = true;
            Close();
        }

        private void Button_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #endregion

        private void Button_create_playlist_Click(object sender, EventArgs e)
        {
            data.Playlist_name = textbox_playlistName_playlist.Text;
            data.Playlist_Description = textbox_description_playlist.Text;
            data.insertplaylist = true;
            data.Dataset();
            buttonactive.Enabled = true;
            //Thread.Sleep(1000);
            new Thread(new ThreadStart(CloseThread)).Start();
        }

        private void CloseThread()
        {
            this.BeginInvoke((MethodInvoker)delegate {
                this.Close();
            });
            
        }
    }
}
