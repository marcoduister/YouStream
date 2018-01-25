namespace YouStream
{
    partial class UserControl_Favorites
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Favorites));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_search = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Textbox_search = new Bunifu.Framework.UI.BunifuTextbox();
            this.panel_video = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.button_search);
            this.panel1.Controls.Add(this.Textbox_search);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 76);
            this.panel1.TabIndex = 2;
            // 
            // button_search
            // 
            this.button_search.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_search.BorderRadius = 4;
            this.button_search.ButtonText = "Search";
            this.button_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_search.DisabledColor = System.Drawing.Color.Gray;
            this.button_search.Iconcolor = System.Drawing.Color.Transparent;
            this.button_search.Iconimage = null;
            this.button_search.Iconimage_right = null;
            this.button_search.Iconimage_right_Selected = null;
            this.button_search.Iconimage_Selected = null;
            this.button_search.IconMarginLeft = 0;
            this.button_search.IconMarginRight = 0;
            this.button_search.IconRightVisible = true;
            this.button_search.IconRightZoom = 0D;
            this.button_search.IconVisible = true;
            this.button_search.IconZoom = 90D;
            this.button_search.IsTab = false;
            this.button_search.Location = new System.Drawing.Point(451, 16);
            this.button_search.Name = "button_search";
            this.button_search.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_search.OnHovercolor = System.Drawing.Color.DarkOrange;
            this.button_search.OnHoverTextColor = System.Drawing.Color.White;
            this.button_search.selected = false;
            this.button_search.Size = new System.Drawing.Size(170, 45);
            this.button_search.TabIndex = 3;
            this.button_search.Text = "Search";
            this.button_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_search.Textcolor = System.Drawing.Color.White;
            this.button_search.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // Textbox_search
            // 
            this.Textbox_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Textbox_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Textbox_search.BackgroundImage")));
            this.Textbox_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Textbox_search.ForeColor = System.Drawing.Color.DarkOrange;
            this.Textbox_search.Icon = ((System.Drawing.Image)(resources.GetObject("Textbox_search.Icon")));
            this.Textbox_search.Location = new System.Drawing.Point(15, 16);
            this.Textbox_search.Name = "Textbox_search";
            this.Textbox_search.Size = new System.Drawing.Size(407, 42);
            this.Textbox_search.TabIndex = 0;
            this.Textbox_search.text = "";
            // 
            // panel_video
            // 
            this.panel_video.AutoScroll = true;
            this.panel_video.Location = new System.Drawing.Point(3, 82);
            this.panel_video.Name = "panel_video";
            this.panel_video.Size = new System.Drawing.Size(689, 498);
            this.panel_video.TabIndex = 3;
            // 
            // UserControl_Favorites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.panel_video);
            this.Controls.Add(this.panel1);
            this.Name = "UserControl_Favorites";
            this.Size = new System.Drawing.Size(692, 575);
            this.Load += new System.EventHandler(this.UserControl_Favorites_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton button_search;
        private Bunifu.Framework.UI.BunifuTextbox Textbox_search;
        private System.Windows.Forms.Panel panel_video;
    }
}
