using System.IO;
using NAudio.Wave;

namespace YouStream
{
    public class MusicPlayer
    {
        public static string MusicPath { get; set; }
        public static string MusicTime { get; set; }
        public musicstate MusicState { get; set; }
        public FileStream Ms { get; set; }
        public Mp3FileReader Rdr { get; set; }
        public WaveStream WavStream { get; set; }
        public BlockAlignReductionStream BarStream { get; set; }
        public WaveOut waveOut { get; set; }
        public string curTimeString { get; set; }
        public int curTimeSeconds { get; set; }
        public string MaxTimeString { get; set; }
        public int MaxTimeSeconds { get; set; }

        public MusicPlayer()
        {
            waveOut = new WaveOut();
        }

        public void StartMusic()
        {
            waveOut.Stop();    

            Ms = File.OpenRead(MusicPath);
            Rdr = new Mp3FileReader(Ms);
            WavStream = WaveFormatConversionStream.CreatePcmStream(Rdr);
            BarStream = new BlockAlignReductionStream(WavStream);
            waveOut.Init(BarStream);
            
            MaxTimeString = WavStream.TotalTime.ToString("mm\\:ss");
            MaxTimeSeconds = (int)WavStream.TotalTime.TotalSeconds;

            Rdr.Position = 0;
            waveOut.Play();
            MusicState = musicstate.Playing;
        }

        public void FastBackward()
        {

        }

        public void FastForward()
        {

        }

        public void GetPosition()
        {
            curTimeString = WavStream.CurrentTime.ToString("mm\\:ss");
            curTimeSeconds = (int)WavStream.CurrentTime.TotalSeconds;
        }

        public void Pause()
        {
            waveOut.Pause();
            MusicState = musicstate.Paused;
        }

        public void Resume()
        {
            waveOut.Resume();
            MusicState = musicstate.Playing;
        }

        public void Stop()
        {
            waveOut.Stop();
            MusicState = musicstate.Waiting;
        }

        public void ChangeTimePosition()
        {

        }

        public enum musicstate
        {
            Waiting = 0,
            Playing = 1,
            Paused = 2
        }
    }
}
