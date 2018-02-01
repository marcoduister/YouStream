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
            this.userControl_Small_Now_Playing1 = new YouStream.UserControl_Small_Now_Playing();
            this.Panel_Left2 = new System.Windows.Forms.Panel();
            this.button_panel_playlist_refresh = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Button_favorites = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Button_download = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Button_MyMusic = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Button_AddPlaylist = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel_playlist = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.panel_upperbar = new System.Windows.Forms.Panel();
            this.Button_minimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.Button_close = new Bunifu.Framework.UI.BunifuImageButton();
            this.main_panel = new System.Windows.Forms.Panel();
            this.Panel_Bottom.SuspendLayout();
            this.Panel_Left2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_panel_playlist_refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_AddPlaylist)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.panel_upperbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Button_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_close)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Left
            // 
            this.Panel_Left.BackColor = System.Drawing.Color.DarkOrange;
            this.Panel_Left.Location = new System.Drawing.Point(0, 31);
            this.Panel_Left.Margin = new System.Windows.Forms.Padding(2);
            this.Panel_Left.Name = "Panel_Left";
            this.Panel_Left.Size = new System.Drawing.Size(56, 650);
            this.Panel_Left.TabIndex = 0;
            // 
            // Panel_Bottom
            // 
            this.Panel_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Panel_Bottom.Controls.Add(this.userControl_Small_Now_Playing1);
            this.Panel_Bottom.Location = new System.Drawing.Point(56, 620);
            this.Panel_Bottom.Margin = new System.Windows.Forms.Padding(2);
            this.Panel_Bottom.Name = "Panel_Bottom";
            this.Panel_Bottom.Size = new System.Drawing.Size(994, 61);
            this.Panel_Bottom.TabIndex = 0;
            // 
            // userControl_Small_Now_Playing1
            // 
            this.userControl_Small_Now_Playing1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.userControl_Small_Now_Playing1.Location = new System.Drawing.Point(244, 0);
            this.userControl_Small_Now_Playing1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userControl_Small_Now_Playing1.Name = "userControl_Small_Now_Playing1";
            this.userControl_Small_Now_Playing1.Size = new System.Drawing.Size(750, 61);
            this.userControl_Small_Now_Playing1.TabIndex = 0;
            // 
            // Panel_Left2
            // 
            this.Panel_Left2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Panel_Left2.Controls.Add(this.button_panel_playlist_refresh);
            this.Panel_Left2.Controls.Add(this.label1);
            this.Panel_Left2.Controls.Add(this.pictureBox2);
            this.Panel_Left2.Controls.Add(this.Button_favorites);
            this.Panel_Left2.Controls.Add(this.Button_download);
            this.Panel_Left2.Controls.Add(this.Button_MyMusic);
            this.Panel_Left2.Controls.Add(this.Button_AddPlaylist);
            this.Panel_Left2.Controls.Add(this.panel_playlist);
            this.Panel_Left2.Location = new System.Drawing.Point(56, 31);
            this.Panel_Left2.Margin = new System.Windows.Forms.Padding(2);
            this.Panel_Left2.Name = "Panel_Left2";
            this.Panel_Left2.Size = new System.Drawing.Size(281, 589);
            this.Panel_Left2.TabIndex = 0;
            // 
            // button_panel_playlist_refresh
            // 
            this.button_panel_playlist_refresh.BackColor = System.Drawing.Color.Transparent;
            this.button_panel_playlist_refresh.ErrorImage = null;
            this.button_panel_playlist_refresh.Image = ((System.Drawing.Image)(resources.GetObject("button_panel_playlist_refresh.Image")));
            this.button_panel_playlist_refresh.ImageActive = null;
            this.button_panel_playlist_refresh.InitialImage = null;
            this.button_panel_playlist_refresh.Location = new System.Drawing.Point(197, 261);
            this.button_panel_playlist_refresh.Margin = new System.Windows.Forms.Padding(2);
            this.button_panel_playlist_refresh.Name = "button_panel_playlist_refresh";
            this.button_panel_playlist_refresh.Size = new System.Drawing.Size(35, 35);
            this.button_panel_playlist_refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_panel_playlist_refresh.TabIndex = 7;
            this.button_panel_playlist_refresh.TabStop = false;
            this.button_panel_playlist_refresh.Zoom = 10;
            this.button_panel_playlist_refresh.Click += new System.EventHandler(this.Button_panel_playlist_refresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Playlist";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::YouStream.Properties.Resources.Playlist_Icon;
            this.pictureBox2.Location = new System.Drawing.Point(5, 257);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
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
            this.Button_favorites.Location = new System.Drawing.Point(0, 207);
            this.Button_favorites.Margin = new System.Windows.Forms.Padding(4);
            this.Button_favorites.Name = "Button_favorites";
            this.Button_favorites.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Button_favorites.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Button_favorites.OnHoverTextColor = System.Drawing.Color.White;
            this.Button_favorites.selected = false;
            this.Button_favorites.Size = new System.Drawing.Size(281, 48);
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
            this.Button_download.Location = new System.Drawing.Point(0, 159);
            this.Button_download.Margin = new System.Windows.Forms.Padding(4);
            this.Button_download.Name = "Button_download";
            this.Button_download.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Button_download.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Button_download.OnHoverTextColor = System.Drawing.Color.White;
            this.Button_download.selected = false;
            this.Button_download.Size = new System.Drawing.Size(281, 48);
            this.Button_download.TabIndex = 0;
            this.Button_download.TabStop = false;
            this.Button_download.Text = " Download                              ";
            this.Button_download.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_download.Textcolor = System.Drawing.Color.White;
            this.Button_download.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_download.Click += new System.EventHandler(this.Button_download_Click);
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
            this.Button_MyMusic.Location = new System.Drawing.Point(0, 111);
            this.Button_MyMusic.Margin = new System.Windows.Forms.Padding(4);
            this.Button_MyMusic.Name = "Button_MyMusic";
            this.Button_MyMusic.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Button_MyMusic.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Button_MyMusic.OnHoverTextColor = System.Drawing.Color.White;
            this.Button_MyMusic.selected = false;
            this.Button_MyMusic.Size = new System.Drawing.Size(281, 48);
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
            this.Button_AddPlaylist.Location = new System.Drawing.Point(236, 256);
            this.Button_AddPlaylist.Margin = new System.Windows.Forms.Padding(2);
            this.Button_AddPlaylist.Name = "Button_AddPlaylist";
            this.Button_AddPlaylist.Size = new System.Drawing.Size(45, 49);
            this.Button_AddPlaylist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_AddPlaylist.TabIndex = 4;
            this.Button_AddPlaylist.TabStop = false;
            this.Button_AddPlaylist.Zoom = 10;
            this.Button_AddPlaylist.Click += new System.EventHandler(this.Button_AddPlaylist_Click);
            // 
            // panel_playlist
            // 
            this.panel_playlist.AutoScroll = true;
            this.panel_playlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel_playlist.Location = new System.Drawing.Point(0, 308);
            this.panel_playlist.Margin = new System.Windows.Forms.Padding(2);
            this.panel_playlist.Name = "panel_playlist";
            this.panel_playlist.Size = new System.Drawing.Size(281, 281);
            this.panel_playlist.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.pictureBox_logo);
            this.panel2.Location = new System.Drawing.Point(56, 31);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 105);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo.Image")));
            this.pictureBox_logo.Location = new System.Drawing.Point(12, 14);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(75, 75);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_logo.TabIndex = 0;
            this.pictureBox_logo.TabStop = false;
            // 
            // panel_upperbar
            // 
            this.panel_upperbar.Controls.Add(this.Button_minimize);
            this.panel_upperbar.Controls.Add(this.Button_close);
            this.panel_upperbar.Location = new System.Drawing.Point(0, 2);
            this.panel_upperbar.Name = "panel_upperbar";
            this.panel_upperbar.Size = new System.Drawing.Size(1050, 30);
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
            this.Button_minimize.Location = new System.Drawing.Point(994, 2);
            this.Button_minimize.Margin = new System.Windows.Forms.Padding(2);
            this.Button_minimize.Name = "Button_minimize";
            this.Button_minimize.Size = new System.Drawing.Size(26, 26);
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
            this.Button_close.Location = new System.Drawing.Point(1022, 2);
            this.Button_close.Margin = new System.Windows.Forms.Padding(2);
            this.Button_close.Name = "Button_close";
            this.Button_close.Size = new System.Drawing.Size(26, 26);
            this.Button_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_close.TabIndex = 8;
            this.Button_close.TabStop = false;
            this.Button_close.Zoom = 10;
            this.Button_close.Click += new System.EventHandler(this.Button_close_Click);
            // 
            // main_panel
            // 
            this.main_panel.Location = new System.Drawing.Point(346, 32);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(692, 583);
            this.main_panel.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1050, 680);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.panel_upperbar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Panel_Left2);
            this.Controls.Add(this.Panel_Bottom);
            this.Controls.Add(this.Panel_Left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Button_maximize_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel_Bottom.ResumeLayout(false);
            this.Panel_Left2.ResumeLayout(false);
            this.Panel_Left2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_panel_playlist_refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_AddPlaylist)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.panel_upperbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Button_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Left;
        private System.Windows.Forms.Panel Panel_Bottom;
        private System.Windows.Forms.Panel Panel_Left2;
        private Bunifu.Framework.UI.BunifuFlatButton Button_favorites;
        private Bunifu.Framework.UI.BunifuFlatButton Button_download;
        private Bunifu.Framework.UI.BunifuFlatButton Button_MyMusic;
        private Bunifu.Framework.UI.BunifuImageButton Button_AddPlaylist;
        private System.Windows.Forms.Panel panel_playlist;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_upperbar;
        private Bunifu.Framework.UI.BunifuImageButton Button_minimize;
        private Bunifu.Framework.UI.BunifuImageButton Button_close;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        public System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuImageButton button_panel_playlist_refresh;
        private UserControl_Small_Now_Playing userControl_Small_Now_Playing1;
    }
}

