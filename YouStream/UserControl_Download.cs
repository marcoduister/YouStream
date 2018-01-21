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

        private void Button_Search_Click(object sender, EventArgs e)
        {
            VideoSearch items = new VideoSearch();
            List<download> list = new List<download>();
            foreach (var item in items.SearchQuery(Textbox_search.text, 1))
            {
                UserControl_videosearch lol = new UserControl_videosearch();

                download videosearch = new download();
                videosearch.Title = item.Title;
                videosearch.author = item.Author;
                videosearch.Url = item.Url;
                byte[] imagebytes = new WebClient().DownloadData(item.Thumbnail);
                using (MemoryStream MS = new MemoryStream(imagebytes))
                {
                    videosearch.Thumbnail = Image.FromStream(MS);
                }

                list.Add(videosearch);
                panel_video.Controls.Add(lol);
                lol.Show();
                lol.Location = new Point(0, 100);

            }
        }
    }
}
