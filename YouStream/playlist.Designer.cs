namespace YouStream
{
    partial class playlist
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playlist));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_upperbar = new System.Windows.Forms.Panel();
            this.Button_minimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.Button_close = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_name_song = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_create_playlist = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_playlistName_playlist = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.textbox_description_playlist = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel_upperbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Button_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_close)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel_upperbar
            // 
            this.panel_upperbar.Controls.Add(this.Button_minimize);
            this.panel_upperbar.Controls.Add(this.Button_close);
            this.panel_upperbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_upperbar.Location = new System.Drawing.Point(0, 0);
            this.panel_upperbar.Name = "panel_upperbar";
            this.panel_upperbar.Size = new System.Drawing.Size(453, 30);
            this.panel_upperbar.TabIndex = 8;
            this.panel_upperbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_upperbar_MouseDown);
            // 
            // Button_minimize
            // 
            this.Button_minimize.BackColor = System.Drawing.Color.Transparent;
            this.Button_minimize.ErrorImage = null;
            this.Button_minimize.Image = ((System.Drawing.Image)(resources.GetObject("Button_minimize.Image")));
            this.Button_minimize.ImageActive = null;
            this.Button_minimize.InitialImage = null;
            this.Button_minimize.Location = new System.Drawing.Point(397, 2);
            this.Button_minimize.Margin = new System.Windows.Forms.Padding(2);
            this.Button_minimize.Name = "Button_minimize";
            this.Button_minimize.Size = new System.Drawing.Size(26, 26);
            this.Button_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_minimize.TabIndex = 12;
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
            this.Button_close.Location = new System.Drawing.Point(425, 2);
            this.Button_close.Margin = new System.Windows.Forms.Padding(2);
            this.Button_close.Name = "Button_close";
            this.Button_close.Size = new System.Drawing.Size(26, 26);
            this.Button_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_close.TabIndex = 11;
            this.Button_close.TabStop = false;
            this.Button_close.Zoom = 10;
            this.Button_close.Click += new System.EventHandler(this.Button_close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label_name_song);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 141);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(147, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Description";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label_name_song
            // 
            this.label_name_song.AutoEllipsis = true;
            this.label_name_song.AutoSize = true;
            this.label_name_song.CausesValidation = false;
            this.label_name_song.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name_song.ForeColor = System.Drawing.Color.Gray;
            this.label_name_song.Location = new System.Drawing.Point(147, 16);
            this.label_name_song.Name = "label_name_song";
            this.label_name_song.Size = new System.Drawing.Size(160, 34);
            this.label_name_song.TabIndex = 7;
            this.label_name_song.Text = "Playlist Name";
            this.label_name_song.UseCompatibleTextRendering = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button_create_playlist
            // 
            this.button_create_playlist.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_create_playlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_create_playlist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_create_playlist.BorderRadius = 0;
            this.button_create_playlist.ButtonText = "Create";
            this.button_create_playlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_create_playlist.DisabledColor = System.Drawing.Color.Gray;
            this.button_create_playlist.ForeColor = System.Drawing.Color.Gray;
            this.button_create_playlist.Iconcolor = System.Drawing.Color.Transparent;
            this.button_create_playlist.Iconimage = null;
            this.button_create_playlist.Iconimage_right = null;
            this.button_create_playlist.Iconimage_right_Selected = null;
            this.button_create_playlist.Iconimage_Selected = null;
            this.button_create_playlist.IconMarginLeft = 0;
            this.button_create_playlist.IconMarginRight = 0;
            this.button_create_playlist.IconRightVisible = true;
            this.button_create_playlist.IconRightZoom = 0D;
            this.button_create_playlist.IconVisible = true;
            this.button_create_playlist.IconZoom = 90D;
            this.button_create_playlist.IsTab = false;
            this.button_create_playlist.Location = new System.Drawing.Point(300, 99);
            this.button_create_playlist.Name = "button_create_playlist";
            this.button_create_playlist.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_create_playlist.OnHovercolor = System.Drawing.Color.DarkOrange;
            this.button_create_playlist.OnHoverTextColor = System.Drawing.Color.White;
            this.button_create_playlist.selected = false;
            this.button_create_playlist.Size = new System.Drawing.Size(125, 48);
            this.button_create_playlist.TabIndex = 10;
            this.button_create_playlist.Text = "Create";
            this.button_create_playlist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_create_playlist.Textcolor = System.Drawing.Color.White;
            this.button_create_playlist.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_create_playlist.Click += new System.EventHandler(this.Button_create_playlist_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textbox_playlistName_playlist);
            this.panel2.Controls.Add(this.textbox_description_playlist);
            this.panel2.Controls.Add(this.button_create_playlist);
            this.panel2.Location = new System.Drawing.Point(13, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 154);
            this.panel2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.CausesValidation = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(4, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Playlist Name";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.CausesValidation = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(4, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Description";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // textbox_playlistName_playlist
            // 
            this.textbox_playlistName_playlist.BorderColorFocused = System.Drawing.Color.DarkOrange;
            this.textbox_playlistName_playlist.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textbox_playlistName_playlist.BorderColorMouseHover = System.Drawing.Color.DarkOrange;
            this.textbox_playlistName_playlist.BorderThickness = 3;
            this.textbox_playlistName_playlist.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_playlistName_playlist.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textbox_playlistName_playlist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textbox_playlistName_playlist.isPassword = false;
            this.textbox_playlistName_playlist.Location = new System.Drawing.Point(4, 27);
            this.textbox_playlistName_playlist.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_playlistName_playlist.Name = "textbox_playlistName_playlist";
            this.textbox_playlistName_playlist.Size = new System.Drawing.Size(352, 44);
            this.textbox_playlistName_playlist.TabIndex = 12;
            this.textbox_playlistName_playlist.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textbox_description_playlist
            // 
            this.textbox_description_playlist.BorderColorFocused = System.Drawing.Color.DarkOrange;
            this.textbox_description_playlist.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textbox_description_playlist.BorderColorMouseHover = System.Drawing.Color.DarkOrange;
            this.textbox_description_playlist.BorderThickness = 3;
            this.textbox_description_playlist.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_description_playlist.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textbox_description_playlist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textbox_description_playlist.isPassword = false;
            this.textbox_description_playlist.Location = new System.Drawing.Point(4, 103);
            this.textbox_description_playlist.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_description_playlist.Name = "textbox_description_playlist";
            this.textbox_description_playlist.Size = new System.Drawing.Size(289, 44);
            this.textbox_description_playlist.TabIndex = 11;
            this.textbox_description_playlist.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(453, 358);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_upperbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "playlist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "playlist";
            this.panel_upperbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Button_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_close)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel_upperbar;
        private Bunifu.Framework.UI.BunifuImageButton Button_minimize;
        private Bunifu.Framework.UI.BunifuImageButton Button_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton button_create_playlist;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label_name_song;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox textbox_playlistName_playlist;
        private Bunifu.Framework.UI.BunifuMetroTextbox textbox_description_playlist;
    }
}