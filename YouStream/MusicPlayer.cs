using System;
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
        public string CurTimeString { get; set; }
        public int CurTimeSeconds { get; set; }
        public string MaxTimeString { get; set; }
        public int MaxTimeSeconds { get; set; }
        public int ByteSecond { get; set; }

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

            long fileLenght = Ms.Length;
            int fileLenght2 = Convert.ToInt32(fileLenght);
            ByteSecond = fileLenght2 / MaxTimeSeconds;
            
            Rdr.Position = 0;
            waveOut.Play();
            MusicState = musicstate.Playing;
        }

        public void SetPositionBar()
        {

        }

        public void TenSecondsBackward()
        {
            int oldBytePosition = Convert.ToInt32(Rdr.Position);
            Rdr.Position = (oldBytePosition - (83 * ByteSecond));
        }

        public void TenSecondsForward()
        {
            WavStream.Skip(10);
        }

        public void GetPosition()
        {
            CurTimeString = WavStream.CurrentTime.ToString("mm\\:ss");
            CurTimeSeconds = (int)WavStream.CurrentTime.TotalSeconds;
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
