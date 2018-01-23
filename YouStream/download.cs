using MediaToolkit;
using MediaToolkit.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using VideoLibrary;


namespace YouStream
{
    class Download
    {
        public string Title { get; set; }
        public string author { get; set; }
        public string Url { get; set; }
        public Image Thumbnail { get; set; }


        public static void SaveVideoToDisk(string link)
        {

            var youTube = YouTube.Default; // starting point for YouTube actions
            var video =  youTube.GetVideo(link); // gets a Video object with info about the video
            string path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            string loc = path +"\\youstream\\"+ video.FullName.ToLower();
            
            File.WriteAllBytes(loc, video.GetBytes());

            var inputFile = new MediaFile { Filename = loc };
            var outputFile = new MediaFile { Filename = loc.Remove(loc.Length - 14)+".mp3" };

            using (var engine = new Engine())
            {
                engine.GetMetadata(inputFile);

                engine.Convert(inputFile, outputFile);
            }
            System.IO.File.Delete(loc);
        }

    }
}

