namespace YouStream
{
    partial class UserControl_videosearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_videosearch));
            this.Thumbnail = new System.Windows.Forms.PictureBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.label_Author = new System.Windows.Forms.Label();
            this.button_download = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.Thumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // Thumbnail
            // 
            this.Thumbnail.Image = ((System.Drawing.Image)(resources.GetObject("Thumbnail.Image")));
            this.Thumbnail.Location = new System.Drawing.Point(3, 3);
            this.Thumbnail.Name = "Thumbnail";
            this.Thumbnail.Size = new System.Drawing.Size(246, 138);
            this.Thumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Thumbnail.TabIndex = 0;
            this.Thumbnail.TabStop = false;
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.Color.Gray;
            this.label_Title.Location = new System.Drawing.Point(255, 29);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(240, 37);
            this.label_Title.TabIndex = 1;
            this.label_Title.Text = "NF - NO NAME";
            // 
            // label_Author
            // 
            this.label_Author.AutoSize = true;
            this.label_Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Author.ForeColor = System.Drawing.Color.Gray;
            this.label_Author.Location = new System.Drawing.Point(258, 66);
            this.label_Author.Name = "label_Author";
            this.label_Author.Size = new System.Drawing.Size(80, 24);
            this.label_Author.TabIndex = 2;
            this.label_Author.Text = "NFVevo";
            // 
            // button_download
            // 
            this.button_download.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_download.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_download.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_download.BorderRadius = 4;
            this.button_download.ButtonText = "Download";
            this.button_download.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_download.DisabledColor = System.Drawing.Color.Gray;
            this.button_download.Iconcolor = System.Drawing.Color.Transparent;
            this.button_download.Iconimage = null;
            this.button_download.Iconimage_right = null;
            this.button_download.Iconimage_right_Selected = null;
            this.button_download.Iconimage_Selected = null;
            this.button_download.IconMarginLeft = 0;
            this.button_download.IconMarginRight = 0;
            this.button_download.IconRightVisible = true;
            this.button_download.IconRightZoom = 0D;
            this.button_download.IconVisible = true;
            this.button_download.IconZoom = 90D;
            this.button_download.IsTab = false;
            this.button_download.Location = new System.Drawing.Point(488, 80);
            this.button_download.Name = "button_download";
            this.button_download.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_download.OnHovercolor = System.Drawing.Color.DarkOrange;
            this.button_download.OnHoverTextColor = System.Drawing.Color.White;
            this.button_download.selected = false;
            this.button_download.Size = new System.Drawing.Size(170, 45);
            this.button_download.TabIndex = 4;
            this.button_download.Text = "Download";
            this.button_download.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_download.Textcolor = System.Drawing.Color.White;
            this.button_download.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // UserControl_videosearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.button_download);
            this.Controls.Add(this.label_Author);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.Thumbnail);
            this.Name = "UserControl_videosearch";
            this.Size = new System.Drawing.Size(689, 144);
            ((System.ComponentModel.ISupportInitialize)(this.Thumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton button_download;
        public System.Windows.Forms.PictureBox Thumbnail;
        public System.Windows.Forms.Label label_Title;
        public System.Windows.Forms.Label label_Author;
    }
}
