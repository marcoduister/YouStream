using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouStream
{
    static class data
    {
        private static SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\marco\\Source\\Repos\\YouStream\\YouStream\\Database1.mdf;Integrated Security=True");

        public static void Dataset()
        {
            try
            { conn.Open(); }
            catch
            {
                MessageBox.Show("can't connect to server");
            }

            SqlCommand newplaylist = new SqlCommand("INSERT INTO playlist (playlist_Name, playlist_Description"/*, playlist_image*/+") VALUES('"+ Playlist_name + "','"+ Playlist_Description + /*, value3*/"');", conn);
            SqlCommand add_songtoplaylist = new SqlCommand("INSERT INTO playlist_song (song_name, song_path, playlist_Id) VALUES(value1, value2, value3);", conn);
            //SqlCommand newplaylist = new SqlCommand(, conn);
            

            SqlDataReader myReader = null;

            myReader = newplaylist.ExecuteReader();

            conn.Close();
        }

        #region bool dataget

        public static bool playlistopvragenbool;


        #endregion

        #region dataget list

        #region playlist info
        public static List<int> playlist_Id_list = new List<int>();
        public static List<string> playlist_Name_list = new List<string>();
        public static List<string> playlist_Description_list = new List<string>();

        #endregion


        #endregion

        public static void Dataget()
        {
            try
            { conn.Open(); }
            catch
            {
                MessageBox.Show("can't connect to server");
            }
            SqlDataReader myReader = null;
            SqlCommand playlistopvragen = new SqlCommand("SELECT * FROM playlist", conn);
            SqlCommand add_songtoplaylist = new SqlCommand("INSERT INTO playlist_song (song_name, song_path, playlist_Id) VALUES(value1, value2, value3);", conn);
            //SqlCommand newplaylist = new SqlCommand(, conn);


            

            if (playlistopvragenbool)
            {
                myReader = playlistopvragen.ExecuteReader();
                while (myReader.Read())
                {
                    playlist_Id_list.Add(Convert.ToInt32(myReader["playlist_Id"]));
                    playlist_Name_list.Add(myReader["playlist_Name"].ToString());
                    playlist_Description_list.Add(myReader["playlist_Description"].ToString());
                }
                playlistopvragenbool = false;
            }

            

            conn.Close();
        }

        #region variable playlist maken
        public static string Playlist_name
        { get; set; }

        public static string Playlist_Description
        { get; set; }

        //hier nog een manier voor vinden
        //public static image playlist_image
        //{ get; set; }


        #endregion
    }
}
