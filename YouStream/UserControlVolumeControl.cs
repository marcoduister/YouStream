using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CoreAudioApi;

namespace YouStream
{
    public partial class UserControlVolumeControl : UserControl
    {
        private readonly MMDevice _device;

        private const int MuteVolume = 524288;
        private const int WmAppcommand = 793;

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        public UserControlVolumeControl()
        {
            InitializeComponent();
            MMDeviceEnumerator devEnum = new MMDeviceEnumerator();
            _device = devEnum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia);
            Slider_Volume.Value = (int)(_device.AudioEndpointVolume.MasterVolumeLevelScalar * 100);
            _device.AudioEndpointVolume.OnVolumeNotification += AudioEndpointVolume_OnVolumeNotification;
            Timer.Enabled = true;
            TimerButtonImage.Enabled = true;
        }

        void AudioEndpointVolume_OnVolumeNotification(AudioVolumeNotificationData data)
        {
            if (InvokeRequired)
            {
                object[] Params = new object[1];
                Params[0] = data;
                Invoke(new AudioEndpointVolumeNotificationDelegate(AudioEndpointVolume_OnVolumeNotification), Params);
            }
            else
            {
                Slider_Volume.Value = (int)(data.MasterVolume * 100);
            }
        }

        private void TimerButtonImage_Tick(object sender, EventArgs e)
        {
            if (Slider_Volume.Value < 1)
            {
                ButtonVolumeMute.Image = Properties.Resources.No_Volume;
            }
            else if (Slider_Volume.Value < 34)
            {
                ButtonVolumeMute.Image = Properties.Resources.Low_Volume;
            }
            else if (Slider_Volume.Value < 67)
            {
                ButtonVolumeMute.Image = Properties.Resources.Medium_Volume;
            }
            else if (Slider_Volume.Value > 67)
            {
                ButtonVolumeMute.Image = Properties.Resources.Maximum_Volume;
            }
        }

        private void ButtonVolumeMute_Click(object sender, EventArgs e)
        {
            SendMessageW(Handle, WmAppcommand, Handle, (IntPtr)MuteVolume);
        }

        private void Slider_Volume_ValueChanged(object sender, EventArgs e)
        {
            _device.AudioEndpointVolume.MasterVolumeLevelScalar = (Slider_Volume.Value / 100.0f);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Label_Volume.Text = Convert.ToString(Slider_Volume.Value);
        }
    }
}
