namespace YouStream
{
    partial class UserControl_playlistresults
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_playlistresults));
            this.label_song_name = new System.Windows.Forms.Label();
            this.button_play = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttin_bin = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.button_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttin_bin)).BeginInit();
            this.SuspendLayout();
            // 
            // label_song_name
            // 
            this.label_song_name.AutoEllipsis = true;
            this.label_song_name.AutoSize = true;
            this.label_song_name.CausesValidation = false;
            this.label_song_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_song_name.ForeColor = System.Drawing.Color.Gray;
            this.label_song_name.Location = new System.Drawing.Point(59, 5);
            this.label_song_name.Name = "label_song_name";
            this.label_song_name.Size = new System.Drawing.Size(167, 34);
            this.label_song_name.TabIndex = 8;
            this.label_song_name.Text = "NF - No Name";
            this.label_song_name.UseCompatibleTextRendering = true;
            // 
            // button_play
            // 
            this.button_play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_play.Image = ((System.Drawing.Image)(resources.GetObject("button_play.Image")));
            this.button_play.ImageActive = null;
            this.button_play.Location = new System.Drawing.Point(616, -3);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(50, 50);
            this.button_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_play.TabIndex = 9;
            this.button_play.TabStop = false;
            this.button_play.Zoom = 10;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // buttin_bin
            // 
            this.buttin_bin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttin_bin.Image = ((System.Drawing.Image)(resources.GetObject("buttin_bin.Image")));
            this.buttin_bin.ImageActive = null;
            this.buttin_bin.Location = new System.Drawing.Point(580, 9);
            this.buttin_bin.Name = "buttin_bin";
            this.buttin_bin.Size = new System.Drawing.Size(30, 30);
            this.buttin_bin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttin_bin.TabIndex = 11;
            this.buttin_bin.TabStop = false;
            this.buttin_bin.Zoom = 10;
            // 
            // UserControl_playlistresults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.buttin_bin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.label_song_name);
            this.Name = "UserControl_playlistresults";
            this.Size = new System.Drawing.Size(669, 44);
            this.Tag = "";
            ((System.ComponentModel.ISupportInitialize)(this.button_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttin_bin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label_song_name;
        private Bunifu.Framework.UI.BunifuImageButton button_play;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton buttin_bin;
    }
}
