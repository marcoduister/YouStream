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
    public partial class UserControl_Now_Playing : UserControl
    {

        public UserControl_Now_Playing()
        {
            InitializeComponent();
        }

        private void Button_PlayPause_Click(object sender, EventArgs e)
        {
            if (Form1.Mp.MusicState == MusicPlayer.musicstate.Playing)
            {
                Form1.Mp.Pause();
                Form1.Mp.MusicState = MusicPlayer.musicstate.Paused;
                Button_PlayPause.Image = Properties.Resources.Play;
                TimerSetPosition.Enabled = false;
            }
            else if (Form1.Mp.MusicState == MusicPlayer.musicstate.Paused)
            {
                Form1.Mp.Resume();
                Form1.Mp.MusicState = MusicPlayer.musicstate.Playing;
                Button_PlayPause.Image = Properties.Resources.Pauze;
                TimerSetPosition.Enabled = true;
            }
        }

        public void TurnOnTimer()
        {
            TimerSetPosition.Enabled = true;
        }

        private void TimerSetPosition_Tick(object sender, EventArgs e)
        {
            Form1.Mp.GetPosition();
            ProgressBar_MusicTIme.Value = Form1.Mp.curTimeSeconds;
        }
    }
}
