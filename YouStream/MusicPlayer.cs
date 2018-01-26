using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace YouStream
{
    public class MusicPlayer
    {
        public static string MusicPath { get; set; }
        public musicstate MusicState { get; set; }
        public FileStream Ms { get; set; }
        public Mp3FileReader Rdr { get; set; }
        public WaveStream WavStream { get; set; }
        public BlockAlignReductionStream BarStream { get; set; }
        public WaveOut waveOut { get; set; }

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
            //}
            //else if (MusicState == musicstate.Playing || MusicState == musicstate.Paused)
            //{
           //     waveOut.Stop();
            //    Ms = File.OpenRead(MusicPath);
            //}

            Rdr.Position = 0;
            waveOut.Play();
            MusicState = musicstate.Playing;
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

        public void ChangeTime()
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
