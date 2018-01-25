using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bunifu.Framework.UI;

namespace YouStream
{
    class Favorites
    {
        public static List<string> favoritelist = new List<string>();
        public static void FavoritesMT(string path, BunifuImageButton button_Favorites)
        {
            if (favoritelist.Contains(path))
            {
                button_Favorites.Image = Properties.Resources.Favorites_off;
                favoritelist.Remove(path);
            }
            else
            {
                favoritelist.Add(path);
                button_Favorites.Image = Properties.Resources.Favorites_on;
            }
        }
        public static void FavoritesLT(string path, BunifuImageButton button_Favorites)
        {
            if (favoritelist.Contains(path))
            {
                button_Favorites.Image = Properties.Resources.Favorites_on;
            }
            else
            {
                button_Favorites.Image = Properties.Resources.Favorites_off;
                
            }
        }
    }
}
