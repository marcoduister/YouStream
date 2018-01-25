namespace YouStream
{
    partial class UserControl_my_music_result
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_my_music_result));
            this.label_name_song = new System.Windows.Forms.Label();
            this.button_play = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Button_Favorites = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.button_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Favorites)).BeginInit();
            this.SuspendLayout();
            // 
            // label_name_song
            // 
            this.label_name_song.AutoEllipsis = true;
            this.label_name_song.AutoSize = true;
            this.label_name_song.CausesValidation = false;
            this.label_name_song.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name_song.ForeColor = System.Drawing.Color.Gray;
            this.label_name_song.Location = new System.Drawing.Point(171, 14);
            this.label_name_song.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_name_song.Name = "label_name_song";
            this.label_name_song.Size = new System.Drawing.Size(222, 41);
            this.label_name_song.TabIndex = 6;
            this.label_name_song.Text = "NF - NO NAME";
            this.label_name_song.UseCompatibleTextRendering = true;
            // 
            // button_play
            // 
            this.button_play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_play.Image = ((System.Drawing.Image)(resources.GetObject("button_play.Image")));
            this.button_play.ImageActive = null;
            this.button_play.Location = new System.Drawing.Point(785, 6);
            this.button_play.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(95, 87);
            this.button_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_play.TabIndex = 7;
            this.button_play.TabStop = false;
            this.button_play.Zoom = 10;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Button_Favorites
            // 
            this.Button_Favorites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Button_Favorites.Image = ((System.Drawing.Image)(resources.GetObject("Button_Favorites.Image")));
            this.Button_Favorites.ImageActive = null;
            this.Button_Favorites.Location = new System.Drawing.Point(116, 9);
            this.Button_Favorites.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button_Favorites.Name = "Button_Favorites";
            this.Button_Favorites.Size = new System.Drawing.Size(53, 49);
            this.Button_Favorites.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_Favorites.TabIndex = 8;
            this.Button_Favorites.TabStop = false;
            this.Button_Favorites.Zoom = 10;
            this.Button_Favorites.Click += new System.EventHandler(this.Button_Favorites_Click);
            // 
            // UserControl_my_music_result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.Button_Favorites);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.label_name_song);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserControl_my_music_result";
            this.Size = new System.Drawing.Size(892, 94);
            this.Load += new System.EventHandler(this.UserControl_my_music_result_Load);
            ((System.ComponentModel.ISupportInitialize)(this.button_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Favorites)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton button_play;
        public System.Windows.Forms.Label label_name_song;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton Button_Favorites;
    }
}
