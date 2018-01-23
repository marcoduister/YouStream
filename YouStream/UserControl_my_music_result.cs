using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouStream
{
    public partial class UserControl_my_music_result : UserControl
    {
        public UserControl_my_music_result()
        {
            InitializeComponent();
        }

        public static bool Favorites;
        private void Button_Favorites_Click(object sender, EventArgs e)
        {

            if (Favorites)
            {
                Button_Favorites.Image = Properties.Resources.Favorites_off;
                Favorites = false;
            }
            else
            {
                Button_Favorites.Image = Properties.Resources.Favorites_on;
                Favorites = true;
            }
            
        }
    }
}
