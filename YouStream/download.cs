using MediaToolkit;
using MediaToolkit.Model;
using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using VideoLibrary;


namespace YouStream
{
    class Download
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Url { get; set; }
        public Image Thumbnail { get; set; }
        public static string Link { get; set; }
        private static Thread download = new Thread(SaveVideoToDisk);

        public static void Startdow(string link)
        {
            Link = link;

            download.Start();
        }

        public static void SaveVideoToDisk()
        {
            var youTube = YouTube.Default; // starting point for YouTube actions
            var video = youTube.GetVideo(Link); // gets a Video object with info about the video
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            string videoFullName = video.FullName.Replace("'", ",");
            string loc = path + "\\youstream\\" + videoFullName.ToLower();

            try
            {
                File.WriteAllBytes(loc, video.GetBytes());

                var inputFile = new MediaFile {Filename = loc};
                var outputFile = new MediaFile {Filename = loc.Remove(loc.Length - 14) + ".mp3"};

                using (var engine = new Engine())
                {
                    engine.GetMetadata(inputFile);

                    engine.Convert(inputFile, outputFile);
                }

                File.Delete(loc);
                download.Abort();
            }
            catch
            {
                MessageBox.Show(@"You can't download this video, This is a Copyrighted video" + @"\r\n" + @"We are trying to fix this problem", @"Can't download video");
            }
        }
    }
}