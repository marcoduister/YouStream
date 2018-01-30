using System;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Windows.Forms;

namespace YouStream
{
    public partial class UserControl_Now_Playing : UserControl
    {

        public UserControl_Now_Playing()
        {
            InitializeComponent();
            TimerSetPosition.Enabled = true;
            Label_MaximumTime.Text = Form1.Mp.MaxTimeString;
            ProgressBar_MusicTIme.Maximum_Value = Form1.Mp.MaxTimeSeconds;
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

        private void TimerSetPosition_Tick(object sender, EventArgs e)
        {
            try
            {
                Form1.Mp.GetPosition();
                Label_CurrentTime.Text = Form1.Mp.CurTimeString;
                ProgressBar_MusicTIme.Value = Form1.Mp.CurTimeSeconds;
            }
            catch
            {
                // ignored
            }
        }

        private void Button_FastForward_Click(object sender, EventArgs e)
        {
            Form1.Mp.TenSecondsForward();
        }

        private void Button_FastBackward_Click(object sender, EventArgs e)
        {
            Form1.Mp.TenSecondsBackward();
        }
    }
}
