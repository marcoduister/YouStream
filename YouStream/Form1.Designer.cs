namespace YouStream
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Panel_Left = new System.Windows.Forms.Panel();
            this.Panel_Bottom = new System.Windows.Forms.Panel();
            this.Button_Volume = new Bunifu.Framework.UI.BunifuImageButton();
            this.Panel_Left2 = new System.Windows.Forms.Panel();
            this.Button_playlists = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Button_favorites = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Button_download = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Button_NowPlaying = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Button_MyMusic = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Button_AddPlaylist = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_upperbar = new System.Windows.Forms.Panel();
            this.Button_minimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.Button_close = new Bunifu.Framework.UI.BunifuImageButton();
            this.main_panel = new System.Windows.Forms.Panel();
            this.userControlVolumeControl1 = new YouStream.UserControlVolumeControl();
            this.Panel_Bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Volume)).BeginInit();
            this.Panel_Left2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Button_AddPlaylist)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_upperbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Button_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_close)).BeginInit();
            this.main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Left
            // 
            this.Panel_Left.BackColor = System.Drawing.Color.DarkOrange;
            this.Panel_Left.Location = new System.Drawing.Point(0, 38);
            this.Panel_Left.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel_Left.Name = "Panel_Left";
            this.Panel_Left.Size = new System.Drawing.Size(75, 800);
            this.Panel_Left.TabIndex = 0;
            // 
            // Panel_Bottom
            // 
            this.Panel_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Panel_Bottom.Controls.Add(this.Button_Volume);
            this.Panel_Bottom.Location = new System.Drawing.Point(75, 763);
            this.Panel_Bottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel_Bottom.Name = "Panel_Bottom";
            this.Panel_Bottom.Size = new System.Drawing.Size(1325, 75);
            this.Panel_Bottom.TabIndex = 0;
            // 
            // Button_Volume
            // 
            this.Button_Volume.BackColor = System.Drawing.Color.Transparent;
            this.Button_Volume.ErrorImage = null;
            this.Button_Volume.Image = global::YouStream.Properties.Resources.Volume_Icon;
            this.Button_Volume.ImageActive = null;
            this.Button_Volume.InitialImage = null;
            this.Button_Volume.Location = new System.Drawing.Point(1267, 18);
            this.Button_Volume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_Volume.Name = "Button_Volume";
            this.Button_Volume.Size = new System.Drawing.Size(40, 39);
            this.Button_Volume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Button_Volume.TabIndex = 1;
            this.Button_Volume.TabStop = false;
            this.Button_Volume.Zoom = 7;
            this.Button_Volume.Click += new System.EventHandler(this.Button_Volume_Click);
            // 
            // Panel_Left2
            // 
            this.Panel_Left2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Panel_Left2.Controls.Add(this.Button_playlists);
            this.Panel_Left2.Controls.Add(this.Button_favorites);
            this.Panel_Left2.Controls.Add(this.Button_download);
            this.Panel_Left2.Controls.Add(this.Button_NowPlaying);
            this.Panel_Left2.Controls.Add(this.Button_MyMusic);
            this.Panel_Left2.Controls.Add(this.Button_AddPlaylist);
            this.Panel_Left2.Controls.Add(this.panel1);
            this.Panel_Left2.Location = new System.Drawing.Point(75, 38);
            this.Panel_Left2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel_Left2.Name = "Panel_Left2";
            this.Panel_Left2.Size = new System.Drawing.Size(375, 725);
            this.Panel_Left2.TabIndex = 0;
            // 
            // Button_playlists
            // 
            this.Button_playlists.Activecolor = System.Drawing.Color.Orange;
            this.Button_playlists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Button_playlists.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_playlists.BorderRadius = 0;
            this.Button_playlists.ButtonText = "Playlists                    ";
            this.Button_playlists.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_playlists.DisabledColor = System.Drawing.Color.Gray;
            this.Button_playlists.Iconcolor = System.Drawing.Color.Transparent;
            this.Button_playlists.Iconimage = global::YouStream.Properties.Resources.Playlist_Icon;
            this.Button_playlists.Iconimage_right = null;
            this.Button_playlists.Iconimage_right_Selected = null;
            this.Button_playlists.Iconimage_Selected = null;
            this.Button_playlists.IconMarginLeft = 0;
            this.Button_playlists.IconMarginRight = 0;
            this.Button_playlists.IconRightVisible = true;
            this.Button_playlists.IconRightZoom = 0D;
            this.Button_playlists.IconVisible = true;
            this.Button_playlists.IconZoom = 80D;
            this.Button_playlists.IsTab = false;
            this.Button_playlists.Location = new System.Drawing.Point(0, 314);
            this.Button_playlists.Margin = new System.Windows.Forms.Padding(5);
            this.Button_playlists.Name = "Button_playlists";
            this.Button_playlists.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Button_playlists.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Button_playlists.OnHoverTextColor = System.Drawing.Color.White;
            this.Button_playlists.selected = false;
            this.Button_playlists.Size = new System.Drawing.Size(315, 59);
            this.Button_playlists.TabIndex = 5;
            this.Button_playlists.TabStop = false;
            this.Button_playlists.Text = "Playlists                    ";
            this.Button_playlists.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_playlists.Textcolor = System.Drawing.Color.White;
            this.Button_playlists.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_playlists.Click += new System.EventHandler(this.Button_playlists_Click);
            // 
            // Button_favorites
            // 
            this.Button_favorites.Activecolor = System.Drawing.Color.Orange;
            this.Button_favorites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Button_favorites.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_favorites.BorderRadius = 0;
            this.Button_favorites.ButtonText = "Favorites                              ";
            this.Button_favorites.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_favorites.DisabledColor = System.Drawing.Color.Gray;
            this.Button_favorites.Iconcolor = System.Drawing.Color.Transparent;
            this.Button_favorites.Iconimage = global::YouStream.Properties.Resources.Favorites_Icon;
            this.Button_favorites.Iconimage_right = null;
            this.Button_favorites.Iconimage_right_Selected = null;
            this.Button_favorites.Iconimage_Selected = null;
            this.Button_favorites.IconMarginLeft = 0;
            this.Button_favorites.IconMarginRight = 0;
            this.Button_favorites.IconRightVisible = true;
            this.Button_favorites.IconRightZoom = 0D;
            this.Button_favorites.IconVisible = true;
            this.Button_favorites.IconZoom = 80D;
            this.Button_favorites.IsTab = false;
            this.Button_favorites.Location = new System.Drawing.Point(0, 255);
            this.Button_favorites.Margin = new System.Windows.Forms.Padding(5);
            this.Button_favorites.Name = "Button_favorites";
            this.Button_favorites.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Button_favorites.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Button_favorites.OnHoverTextColor = System.Drawing.Color.White;
            this.Button_favorites.selected = false;
            this.Button_favorites.Size = new System.Drawing.Size(375, 59);
            this.Button_favorites.TabIndex = 0;
            this.Button_favorites.TabStop = false;
            this.Button_favorites.Text = "Favorites                              ";
            this.Button_favorites.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_favorites.Textcolor = System.Drawing.Color.White;
            this.Button_favorites.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_favorites.Click += new System.EventHandler(this.Button_favorites_Click);
            // 
            // Button_download
            // 
            this.Button_download.Activecolor = System.Drawing.Color.Orange;
            this.Button_download.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Button_download.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_download.BorderRadius = 0;
            this.Button_download.ButtonText = " Download                              ";
            this.Button_download.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_download.DisabledColor = System.Drawing.Color.Gray;
            this.Button_download.Iconcolor = System.Drawing.Color.Transparent;
            this.Button_download.Iconimage = global::YouStream.Properties.Resources.Now_Playing_Icon;
            this.Button_download.Iconimage_right = null;
            this.Button_download.Iconimage_right_Selected = null;
            this.Button_download.Iconimage_Selected = null;
            this.Button_download.IconMarginLeft = 0;
            this.Button_download.IconMarginRight = 0;
            this.Button_download.IconRightVisible = true;
            this.Button_download.IconRightZoom = 0D;
            this.Button_download.IconVisible = true;
            this.Button_download.IconZoom = 80D;
            this.Button_download.IsTab = false;
            this.Button_download.Location = new System.Drawing.Point(0, 196);
            this.Button_download.Margin = new System.Windows.Forms.Padding(5);
            this.Button_download.Name = "Button_download";
            this.Button_download.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Button_download.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Button_download.OnHoverTextColor = System.Drawing.Color.White;
            this.Button_download.selected = false;
            this.Button_download.Size = new System.Drawing.Size(375, 59);
            this.Button_download.TabIndex = 0;
            this.Button_download.TabStop = false;
            this.Button_download.Text = " Download                              ";
            this.Button_download.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_download.Textcolor = System.Drawing.Color.White;
            this.Button_download.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_download.Click += new System.EventHandler(this.Button_download_Click);
            // 
            // Button_NowPlaying
            // 
            this.Button_NowPlaying.Activecolor = System.Drawing.Color.Orange;
            this.Button_NowPlaying.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Button_NowPlaying.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_NowPlaying.BorderRadius = 0;
            this.Button_NowPlaying.ButtonText = "Now Playing                          ";
            this.Button_NowPlaying.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_NowPlaying.DisabledColor = System.Drawing.Color.Gray;
            this.Button_NowPlaying.Iconcolor = System.Drawing.Color.Transparent;
            this.Button_NowPlaying.Iconimage = global::YouStream.Properties.Resources.Recently_Played_Icon;
            this.Button_NowPlaying.Iconimage_right = null;
            this.Button_NowPlaying.Iconimage_right_Selected = null;
            this.Button_NowPlaying.Iconimage_Selected = null;
            this.Button_NowPlaying.IconMarginLeft = 0;
            this.Button_NowPlaying.IconMarginRight = 0;
            this.Button_NowPlaying.IconRightVisible = true;
            this.Button_NowPlaying.IconRightZoom = 0D;
            this.Button_NowPlaying.IconVisible = true;
            this.Button_NowPlaying.IconZoom = 80D;
            this.Button_NowPlaying.IsTab = false;
            this.Button_NowPlaying.Location = new System.Drawing.Point(0, 137);
            this.Button_NowPlaying.Margin = new System.Windows.Forms.Padding(5);
            this.Button_NowPlaying.Name = "Button_NowPlaying";
            this.Button_NowPlaying.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Button_NowPlaying.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Button_NowPlaying.OnHoverTextColor = System.Drawing.Color.White;
            this.Button_NowPlaying.selected = false;
            this.Button_NowPlaying.Size = new System.Drawing.Size(375, 59);
            this.Button_NowPlaying.TabIndex = 0;
            this.Button_NowPlaying.TabStop = false;
            this.Button_NowPlaying.Text = "Now Playing                          ";
            this.Button_NowPlaying.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_NowPlaying.Textcolor = System.Drawing.Color.White;
            this.Button_NowPlaying.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_NowPlaying.Click += new System.EventHandler(this.Button_RecentlyPlayed_Click);
            // 
            // Button_MyMusic
            // 
            this.Button_MyMusic.Activecolor = System.Drawing.Color.Orange;
            this.Button_MyMusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Button_MyMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_MyMusic.BorderRadius = 0;
            this.Button_MyMusic.ButtonText = "My Music                              ";
            this.Button_MyMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_MyMusic.DisabledColor = System.Drawing.Color.Gray;
            this.Button_MyMusic.Iconcolor = System.Drawing.Color.Transparent;
            this.Button_MyMusic.Iconimage = global::YouStream.Properties.Resources.My_Music_Icon;
            this.Button_MyMusic.Iconimage_right = null;
            this.Button_MyMusic.Iconimage_right_Selected = null;
            this.Button_MyMusic.Iconimage_Selected = null;
            this.Button_MyMusic.IconMarginLeft = 0;
            this.Button_MyMusic.IconMarginRight = 0;
            this.Button_MyMusic.IconRightVisible = true;
            this.Button_MyMusic.IconRightZoom = 0D;
            this.Button_MyMusic.IconVisible = true;
            this.Button_MyMusic.IconZoom = 80D;
            this.Button_MyMusic.IsTab = false;
            this.Button_MyMusic.Location = new System.Drawing.Point(0, 78);
            this.Button_MyMusic.Margin = new System.Windows.Forms.Padding(5);
            this.Button_MyMusic.Name = "Button_MyMusic";
            this.Button_MyMusic.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Button_MyMusic.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Button_MyMusic.OnHoverTextColor = System.Drawing.Color.White;
            this.Button_MyMusic.selected = false;
            this.Button_MyMusic.Size = new System.Drawing.Size(375, 59);
            this.Button_MyMusic.TabIndex = 0;
            this.Button_MyMusic.TabStop = false;
            this.Button_MyMusic.Text = "My Music                              ";
            this.Button_MyMusic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_MyMusic.Textcolor = System.Drawing.Color.White;
            this.Button_MyMusic.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_MyMusic.Click += new System.EventHandler(this.Button_MyMusic_Click);
            // 
            // Button_AddPlaylist
            // 
            this.Button_AddPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.Button_AddPlaylist.ErrorImage = null;
            this.Button_AddPlaylist.Image = global::YouStream.Properties.Resources.Add_Playlist_Icon;
            this.Button_AddPlaylist.ImageActive = null;
            this.Button_AddPlaylist.InitialImage = null;
            this.Button_AddPlaylist.Location = new System.Drawing.Point(315, 314);
            this.Button_AddPlaylist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_AddPlaylist.Name = "Button_AddPlaylist";
            this.Button_AddPlaylist.Size = new System.Drawing.Size(60, 60);
            this.Button_AddPlaylist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_AddPlaylist.TabIndex = 4;
            this.Button_AddPlaylist.TabStop = false;
            this.Button_AddPlaylist.Zoom = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Location = new System.Drawing.Point(0, 379);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 346);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(75, 38);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 71);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel_upperbar
            // 
            this.panel_upperbar.Controls.Add(this.Button_minimize);
            this.panel_upperbar.Controls.Add(this.Button_close);
            this.panel_upperbar.Location = new System.Drawing.Point(0, 2);
            this.panel_upperbar.Margin = new System.Windows.Forms.Padding(4);
            this.panel_upperbar.Name = "panel_upperbar";
            this.panel_upperbar.Size = new System.Drawing.Size(1400, 37);
            this.panel_upperbar.TabIndex = 7;
            this.panel_upperbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_upperbar_MouseDown);
            // 
            // Button_minimize
            // 
            this.Button_minimize.BackColor = System.Drawing.Color.Transparent;
            this.Button_minimize.ErrorImage = null;
            this.Button_minimize.Image = ((System.Drawing.Image)(resources.GetObject("Button_minimize.Image")));
            this.Button_minimize.ImageActive = null;
            this.Button_minimize.InitialImage = null;
            this.Button_minimize.Location = new System.Drawing.Point(1325, 2);
            this.Button_minimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_minimize.Name = "Button_minimize";
            this.Button_minimize.Size = new System.Drawing.Size(35, 32);
            this.Button_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_minimize.TabIndex = 10;
            this.Button_minimize.TabStop = false;
            this.Button_minimize.Zoom = 10;
            this.Button_minimize.Click += new System.EventHandler(this.Button_minimize_Click);
            // 
            // Button_close
            // 
            this.Button_close.BackColor = System.Drawing.Color.Transparent;
            this.Button_close.ErrorImage = null;
            this.Button_close.Image = ((System.Drawing.Image)(resources.GetObject("Button_close.Image")));
            this.Button_close.ImageActive = null;
            this.Button_close.InitialImage = null;
            this.Button_close.Location = new System.Drawing.Point(1363, 2);
            this.Button_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_close.Name = "Button_close";
            this.Button_close.Size = new System.Drawing.Size(35, 32);
            this.Button_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_close.TabIndex = 8;
            this.Button_close.TabStop = false;
            this.Button_close.Zoom = 10;
            this.Button_close.Click += new System.EventHandler(this.Button_close_Click);
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.userControlVolumeControl1);
            this.main_panel.Location = new System.Drawing.Point(461, 39);
            this.main_panel.Margin = new System.Windows.Forms.Padding(4);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(923, 718);
            this.main_panel.TabIndex = 8;
            // 
            // userControlVolumeControl1
            // 
            this.userControlVolumeControl1.BackColor = System.Drawing.Color.DarkGray;
            this.userControlVolumeControl1.Location = new System.Drawing.Point(489, 563);
            this.userControlVolumeControl1.Name = "userControlVolumeControl1";
            this.userControlVolumeControl1.Size = new System.Drawing.Size(400, 150);
            this.userControlVolumeControl1.TabIndex = 0;
            this.userControlVolumeControl1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1400, 837);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.panel_upperbar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Panel_Left2);
            this.Controls.Add(this.Panel_Bottom);
            this.Controls.Add(this.Panel_Left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Button_maximize_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel_Bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Button_Volume)).EndInit();
            this.Panel_Left2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Button_AddPlaylist)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_upperbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Button_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_close)).EndInit();
            this.main_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Left;
        private System.Windows.Forms.Panel Panel_Bottom;
        private Bunifu.Framework.UI.BunifuImageButton Button_Volume;
        private System.Windows.Forms.Panel Panel_Left2;
        private Bunifu.Framework.UI.BunifuFlatButton Button_playlists;
        private Bunifu.Framework.UI.BunifuFlatButton Button_favorites;
        private Bunifu.Framework.UI.BunifuFlatButton Button_download;
        private Bunifu.Framework.UI.BunifuFlatButton Button_NowPlaying;
        private Bunifu.Framework.UI.BunifuFlatButton Button_MyMusic;
        private Bunifu.Framework.UI.BunifuImageButton Button_AddPlaylist;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_upperbar;
        private Bunifu.Framework.UI.BunifuImageButton Button_minimize;
        private Bunifu.Framework.UI.BunifuImageButton Button_close;
        public System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UserControlVolumeControl userControlVolumeControl1;
    }
}

