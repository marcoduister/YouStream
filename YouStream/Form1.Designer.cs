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
            this.Panel_Left = new System.Windows.Forms.Panel();
            this.Panel_Bottom = new System.Windows.Forms.Panel();
            this.Button_Volume = new Bunifu.Framework.UI.BunifuImageButton();
            this.Slider_Time = new Bunifu.Framework.UI.BunifuSlider();
            this.Panel_Left2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Button_AddPlaylist = new Bunifu.Framework.UI.BunifuImageButton();
            this.Button_MyMusic = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Button_RecentlyPlayed = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Panel_Bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Volume)).BeginInit();
            this.Panel_Left2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Button_AddPlaylist)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Left
            // 
            this.Panel_Left.BackColor = System.Drawing.Color.DarkOrange;
            this.Panel_Left.Location = new System.Drawing.Point(0, 0);
            this.Panel_Left.Name = "Panel_Left";
            this.Panel_Left.Size = new System.Drawing.Size(75, 800);
            this.Panel_Left.TabIndex = 0;
            // 
            // Panel_Bottom
            // 
            this.Panel_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Panel_Bottom.Controls.Add(this.Button_Volume);
            this.Panel_Bottom.Controls.Add(this.Slider_Time);
            this.Panel_Bottom.Location = new System.Drawing.Point(75, 725);
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
            this.Button_Volume.Location = new System.Drawing.Point(1266, 18);
            this.Button_Volume.Name = "Button_Volume";
            this.Button_Volume.Size = new System.Drawing.Size(40, 40);
            this.Button_Volume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Button_Volume.TabIndex = 1;
            this.Button_Volume.TabStop = false;
            this.Button_Volume.Zoom = 7;
            // 
            // Slider_Time
            // 
            this.Slider_Time.BackColor = System.Drawing.Color.Transparent;
            this.Slider_Time.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Slider_Time.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Slider_Time.BorderRadius = 7;
            this.Slider_Time.IndicatorColor = System.Drawing.Color.Orange;
            this.Slider_Time.Location = new System.Drawing.Point(387, 20);
            this.Slider_Time.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Slider_Time.MaximumValue = 100;
            this.Slider_Time.Name = "Slider_Time";
            this.Slider_Time.Size = new System.Drawing.Size(644, 35);
            this.Slider_Time.TabIndex = 0;
            this.Slider_Time.TabStop = false;
            this.Slider_Time.Value = 0;
            // 
            // Panel_Left2
            // 
            this.Panel_Left2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Panel_Left2.Controls.Add(this.bunifuFlatButton1);
            this.Panel_Left2.Controls.Add(this.bunifuFlatButton2);
            this.Panel_Left2.Controls.Add(this.bunifuFlatButton3);
            this.Panel_Left2.Controls.Add(this.Button_RecentlyPlayed);
            this.Panel_Left2.Controls.Add(this.Button_MyMusic);
            this.Panel_Left2.Controls.Add(this.Button_AddPlaylist);
            this.Panel_Left2.Controls.Add(this.panel1);
            this.Panel_Left2.Location = new System.Drawing.Point(75, 0);
            this.Panel_Left2.Name = "Panel_Left2";
            this.Panel_Left2.Size = new System.Drawing.Size(375, 725);
            this.Panel_Left2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Location = new System.Drawing.Point(0, 375);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 350);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 75);
            this.panel2.TabIndex = 6;
            // 
            // Button_AddPlaylist
            // 
            this.Button_AddPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.Button_AddPlaylist.ErrorImage = null;
            this.Button_AddPlaylist.Image = global::YouStream.Properties.Resources.Add_Playlist_Icon;
            this.Button_AddPlaylist.ImageActive = null;
            this.Button_AddPlaylist.InitialImage = null;
            this.Button_AddPlaylist.Location = new System.Drawing.Point(315, 311);
            this.Button_AddPlaylist.Name = "Button_AddPlaylist";
            this.Button_AddPlaylist.Size = new System.Drawing.Size(60, 60);
            this.Button_AddPlaylist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_AddPlaylist.TabIndex = 4;
            this.Button_AddPlaylist.TabStop = false;
            this.Button_AddPlaylist.Zoom = 10;
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
            this.Button_MyMusic.Location = new System.Drawing.Point(0, 75);
            this.Button_MyMusic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            // 
            // Button_RecentlyPlayed
            // 
            this.Button_RecentlyPlayed.Activecolor = System.Drawing.Color.Orange;
            this.Button_RecentlyPlayed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Button_RecentlyPlayed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_RecentlyPlayed.BorderRadius = 0;
            this.Button_RecentlyPlayed.ButtonText = "Recently Played                   ";
            this.Button_RecentlyPlayed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_RecentlyPlayed.DisabledColor = System.Drawing.Color.Gray;
            this.Button_RecentlyPlayed.Iconcolor = System.Drawing.Color.Transparent;
            this.Button_RecentlyPlayed.Iconimage = global::YouStream.Properties.Resources.Recently_Played_Icon;
            this.Button_RecentlyPlayed.Iconimage_right = null;
            this.Button_RecentlyPlayed.Iconimage_right_Selected = null;
            this.Button_RecentlyPlayed.Iconimage_Selected = null;
            this.Button_RecentlyPlayed.IconMarginLeft = 0;
            this.Button_RecentlyPlayed.IconMarginRight = 0;
            this.Button_RecentlyPlayed.IconRightVisible = true;
            this.Button_RecentlyPlayed.IconRightZoom = 0D;
            this.Button_RecentlyPlayed.IconVisible = true;
            this.Button_RecentlyPlayed.IconZoom = 80D;
            this.Button_RecentlyPlayed.IsTab = false;
            this.Button_RecentlyPlayed.Location = new System.Drawing.Point(0, 134);
            this.Button_RecentlyPlayed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button_RecentlyPlayed.Name = "Button_RecentlyPlayed";
            this.Button_RecentlyPlayed.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Button_RecentlyPlayed.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Button_RecentlyPlayed.OnHoverTextColor = System.Drawing.Color.White;
            this.Button_RecentlyPlayed.selected = false;
            this.Button_RecentlyPlayed.Size = new System.Drawing.Size(375, 59);
            this.Button_RecentlyPlayed.TabIndex = 0;
            this.Button_RecentlyPlayed.TabStop = false;
            this.Button_RecentlyPlayed.Text = "Recently Played                   ";
            this.Button_RecentlyPlayed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_RecentlyPlayed.Textcolor = System.Drawing.Color.White;
            this.Button_RecentlyPlayed.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.Orange;
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Now Playing                         ";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = global::YouStream.Properties.Resources.Now_Playing_Icon;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 80D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(0, 193);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(375, 59);
            this.bunifuFlatButton3.TabIndex = 0;
            this.bunifuFlatButton3.TabStop = false;
            this.bunifuFlatButton3.Text = "Now Playing                         ";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Orange;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Favorites                              ";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = global::YouStream.Properties.Resources.Favorites_Icon;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 80D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 252);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(375, 59);
            this.bunifuFlatButton2.TabIndex = 0;
            this.bunifuFlatButton2.TabStop = false;
            this.bunifuFlatButton2.Text = "Favorites                              ";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Orange;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Playlists                    ";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::YouStream.Properties.Resources.Playlist_Icon;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 80D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 311);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(315, 59);
            this.bunifuFlatButton1.TabIndex = 5;
            this.bunifuFlatButton1.TabStop = false;
            this.bunifuFlatButton1.Text = "Playlists                    ";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Panel_Left2);
            this.Controls.Add(this.Panel_Bottom);
            this.Controls.Add(this.Panel_Left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Panel_Bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Button_Volume)).EndInit();
            this.Panel_Left2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Button_AddPlaylist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Left;
        private System.Windows.Forms.Panel Panel_Bottom;
        private Bunifu.Framework.UI.BunifuSlider Slider_Time;
        private System.Windows.Forms.Panel Panel_Left2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton Button_Volume;
        private Bunifu.Framework.UI.BunifuFlatButton Button_RecentlyPlayed;
        private Bunifu.Framework.UI.BunifuFlatButton Button_MyMusic;
        private Bunifu.Framework.UI.BunifuImageButton Button_AddPlaylist;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
    }
}

