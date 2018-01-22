using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeSearch;
using System.Net;
using System.IO;

namespace YouStream
{
    public partial class UserControl_Download : UserControl
    {
        public UserControl_Download()
        {
            InitializeComponent();

        }
        
        private void button_search_Click(object sender, EventArgs e)
        {
            panel_video.Controls.Clear();
            VideoSearch items = new VideoSearch();
            List<Download> list = new List<Download>();
            int aantal = list.Count;
            int height = 0;
            foreach (var item in items.SearchQuery(Textbox_search.text, 1))
            {
                

                Download videosearch = new Download();
                videosearch.Title = item.Title;
                videosearch.author = item.Author;
                videosearch.Url = item.Url;
                byte[] imagebytes = new WebClient().DownloadData(item.Thumbnail);
                using (MemoryStream MS = new MemoryStream(imagebytes))
                {
                    videosearch.Thumbnail = Image.FromStream(MS);
                }
                list.Add(videosearch);
                UserControl_videosearch video_panel = new UserControl_videosearch();

                panel_video.Controls.Add(video_panel);
                video_panel.label_Title.Text = videosearch.Title;
                video_panel.label_Author.Text = videosearch.author;
                video_panel.Thumbnail.Image = videosearch.Thumbnail;
                video_panel.Url = videosearch.Url;
                video_panel.Thumbnail.Size = new Size(246, 138);
                video_panel.Location = new Point(0, height);
                height += 152;
            }
        }
    }
}
