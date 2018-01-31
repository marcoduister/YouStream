using System.Windows.Forms;
using CoreAudioApi;

namespace YouStream
{
    public partial class UserControl_Small_Now_Playing : UserControl
    {
        private readonly MMDevice _device;

        public UserControl_Small_Now_Playing()
        {
            InitializeComponent();
            MMDeviceEnumerator devEnum = new MMDeviceEnumerator();
            _device = devEnum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia);
            ProgressBar_Volume.Value = (int)(_device.AudioEndpointVolume.MasterVolumeLevelScalar * 100);
            _device.AudioEndpointVolume.OnVolumeNotification += AudioEndpointVolume_OnVolumeNotification;
            Timer.Enabled = true;
        }

        private void AudioEndpointVolume_OnVolumeNotification(AudioVolumeNotificationData data)
        {
            if (InvokeRequired)
            {
                object[] Params = new object[1];
                Params[0] = data;
                Invoke(new AudioEndpointVolumeNotificationDelegate(AudioEndpointVolume_OnVolumeNotification), Params);
            }
            else
            {
                ProgressBar_Volume.Value = (int)(data.MasterVolume * 100);
            }
        }

        private void ProgressBar_Volume_MouseClick(object sender, MouseEventArgs e)
        {
            int mousePosition = e.X;
            ProgressBar_Volume.Value = mousePosition;
            _device.AudioEndpointVolume.MasterVolumeLevelScalar = (ProgressBar_Volume.Value / 100.0f);
        }

        private void Timer_Tick(object sender, System.EventArgs e)
        {
            if (Label_MaximimTime.Text != Form1.Mp.MaxTimeString)
            {
                Label_MaximimTime.Text = Form1.Mp.MaxTimeString;
                ProgressBar_MusicTime.Maximum_Value = Form1.Mp.MaxTimeSeconds;
            }
            try
            {
                Form1.Mp.GetPosition();
                Label_CurrentTime.Text = Form1.Mp.CurTimeString;
                ProgressBar_MusicTime.Value = Form1.Mp.CurTimeSeconds;
            }
            catch
            {
                // ignored
            }
        }

        private void Button_PlayPause_Click(object sender, System.EventArgs e)
        {
            if (Form1.Mp.MusicState == MusicPlayer.musicstate.Playing)
            {
                Form1.Mp.Pause();
                Form1.Mp.MusicState = MusicPlayer.musicstate.Paused;
                Button_PlayPause.Image = Properties.Resources.Play;
                Timer.Enabled = false;
            }
            else if (Form1.Mp.MusicState == MusicPlayer.musicstate.Paused)
            {
                Form1.Mp.Resume();
                Form1.Mp.MusicState = MusicPlayer.musicstate.Playing;
                Button_PlayPause.Image = Properties.Resources.Pauze;
                Timer.Enabled = true;
            }
        }

        private void Button_FastForward_Click(object sender, System.EventArgs e)
        {
            Form1.Mp.TenSecondsForward();
        }

        private void Button_FastBackward_Click(object sender, System.EventArgs e)
        {
            Form1.Mp.TenSecondsBackward();
        }
    }
}
