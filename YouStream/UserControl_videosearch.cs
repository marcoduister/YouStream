using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.IO;
using VideoLibrary;
using System.Threading;

namespace YouStream
{
    public partial class UserControl_videosearch : UserControl
    {
        

        public UserControl_videosearch()
        {
            InitializeComponent();
        }

        public string Url { get; set; }

        private void button_download_Click(object sender, EventArgs e)
        {

            Download.Startdow(Url);
        }

    }
}
