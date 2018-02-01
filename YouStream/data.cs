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



        #region insert music playlist

        public static string Insert_path_song { get; set; }
        public static string Insert_name_song { get; set; }
        public  static int Insert_playlist_id { get; set; }

        #endregion

        public static void Dataset()
        {
            try
            { conn.Open(); }
            catch
            {
                MessageBox.Show("can't connect to server");
            }

            SqlCommand newplaylist = new SqlCommand("INSERT INTO playlist (playlist_Name, playlist_Description"/*, playlist_image*/+") VALUES('"+ Playlist_name + "','"+ Playlist_Description + /*, value3*/"');", conn);
            SqlCommand add_songtoplaylist = new SqlCommand("INSERT INTO playlist_song (song_name,song_path,playlist_Id)VALUES('"+Insert_name_song+"','"+Insert_path_song+"','"+Insert_playlist_id+"');", conn);
            

            SqlDataReader myReader = null;

            if (insertplaylist)
            {
                myReader = newplaylist.ExecuteReader();
                insertplaylist = false;
            }
            if(insertsong)
            {
                myReader = add_songtoplaylist.ExecuteReader();
                insertsong = false;
            }
            

            conn.Close();
        }

        #region bool dataget

        public static bool insertplaylist;
        public static bool insertsong;


        #endregion
        #region bool dataget

        public static bool playlistopvragenbool;
        public static bool songopvragenbool;


        #endregion

        #region dataget list

        #region playlist info
        public static List<int> playlist_Id_list = new List<int>();
        public static List<string> playlist_Name_list = new List<string>();
        public static List<string> playlist_Description_list = new List<string>();

        #endregion

        #region song_list
        public static List<int> song_Id_list = new List<int>();
        public static List<string> song_Name_list = new List<string>();
        public static List<string> song_path_list = new List<string>();

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
            SqlCommand playlist_songslist = new SqlCommand("SELECT * FROM playlist_song WHERE playlist_id = '"+Playlist_idget+"' ORDER BY song_name ASC; ", conn);
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
            if (songopvragenbool)
            {
                myReader = playlist_songslist.ExecuteReader();
                while (myReader.Read())
                {
                    song_Id_list.Add(Convert.ToInt32(myReader["playlist_song_Id"]));
                    song_Name_list.Add(myReader["song_name"].ToString());
                    song_path_list.Add(myReader["song_path"].ToString());
                }
                songopvragenbool = false;
            }



            conn.Close();
        }


        public static int Playlist_idget { get; set; }

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
