namespace YouStream
{
    partial class playlist_litle
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playlist_litle));
            this.button_refresh_playlist = new Bunifu.Framework.UI.BunifuImageButton();
            this.label_playlist = new System.Windows.Forms.Label();
            this.button_play = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.button_refresh_playlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_play)).BeginInit();
            this.SuspendLayout();
            // 
            // button_refresh_playlist
            // 
            this.button_refresh_playlist.BackColor = System.Drawing.Color.Transparent;
            this.button_refresh_playlist.ErrorImage = null;
            this.button_refresh_playlist.Image = ((System.Drawing.Image)(resources.GetObject("button_refresh_playlist.Image")));
            this.button_refresh_playlist.ImageActive = null;
            this.button_refresh_playlist.InitialImage = null;
            this.button_refresh_playlist.Location = new System.Drawing.Point(225, 3);
            this.button_refresh_playlist.Margin = new System.Windows.Forms.Padding(2);
            this.button_refresh_playlist.Name = "button_refresh_playlist";
            this.button_refresh_playlist.Size = new System.Drawing.Size(34, 36);
            this.button_refresh_playlist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_refresh_playlist.TabIndex = 8;
            this.button_refresh_playlist.TabStop = false;
            this.button_refresh_playlist.Zoom = 10;
            // 
            // label_playlist
            // 
            this.label_playlist.AutoEllipsis = true;
            this.label_playlist.AutoSize = true;
            this.label_playlist.CausesValidation = false;
            this.label_playlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_playlist.ForeColor = System.Drawing.Color.White;
            this.label_playlist.Location = new System.Drawing.Point(50, 3);
            this.label_playlist.Name = "label_playlist";
            this.label_playlist.Size = new System.Drawing.Size(127, 27);
            this.label_playlist.TabIndex = 9;
            this.label_playlist.Text = "Playlist Name";
            this.label_playlist.UseCompatibleTextRendering = true;
            // 
            // button_play
            // 
            this.button_play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_play.Image = ((System.Drawing.Image)(resources.GetObject("button_play.Image")));
            this.button_play.ImageActive = null;
            this.button_play.Location = new System.Drawing.Point(0, -2);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(44, 44);
            this.button_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_play.TabIndex = 10;
            this.button_play.TabStop = false;
            this.button_play.Zoom = 10;
            // 
            // playlist_litle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.label_playlist);
            this.Controls.Add(this.button_refresh_playlist);
            this.Name = "playlist_litle";
            this.Size = new System.Drawing.Size(262, 42);
            ((System.ComponentModel.ISupportInitialize)(this.button_refresh_playlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_play)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.Framework.UI.BunifuImageButton button_refresh_playlist;
        public System.Windows.Forms.Label label_playlist;
        private Bunifu.Framework.UI.BunifuImageButton button_play;
    }
}
