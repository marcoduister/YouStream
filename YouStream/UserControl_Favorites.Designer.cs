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
            this.panel_video = new System.Windows.Forms.Panel();
            this.bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.Textbox_search = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.Textbox_search);
            this.panel1.Controls.Add(this.bunifuTextbox1);
            this.panel1.Controls.Add(this.button_search);
            this.panel1.Location = new System.Drawing.Point(4, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 94);
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
            this.button_search.Location = new System.Drawing.Point(601, 20);
            this.button_search.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button_search.Name = "button_search";
            this.button_search.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_search.OnHovercolor = System.Drawing.Color.DarkOrange;
            this.button_search.OnHoverTextColor = System.Drawing.Color.White;
            this.button_search.selected = false;
            this.button_search.Size = new System.Drawing.Size(227, 55);
            this.button_search.TabIndex = 3;
            this.button_search.Text = "Search";
            this.button_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_search.Textcolor = System.Drawing.Color.White;
            this.button_search.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // panel_video
            // 
            this.panel_video.AutoScroll = true;
            this.panel_video.Location = new System.Drawing.Point(4, 101);
            this.panel_video.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_video.Name = "panel_video";
            this.panel_video.Size = new System.Drawing.Size(919, 613);
            this.panel_video.TabIndex = 3;
            // 
            // bunifuTextbox1
            // 
            this.bunifuTextbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.BackgroundImage")));
            this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox1.Enabled = false;
            this.bunifuTextbox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
            this.bunifuTextbox1.Location = new System.Drawing.Point(20, 20);
            this.bunifuTextbox1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuTextbox1.Name = "bunifuTextbox1";
            this.bunifuTextbox1.Size = new System.Drawing.Size(543, 52);
            this.bunifuTextbox1.TabIndex = 7;
            this.bunifuTextbox1.text = "";
            // 
            // Textbox_search
            // 
            this.Textbox_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Textbox_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Textbox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_search.ForeColor = System.Drawing.Color.DarkOrange;
            this.Textbox_search.Location = new System.Drawing.Point(66, 32);
            this.Textbox_search.Name = "Textbox_search";
            this.Textbox_search.Size = new System.Drawing.Size(485, 27);
            this.Textbox_search.TabIndex = 0;
            this.Textbox_search.TabStop = false;
            this.Textbox_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textbox_search_KeyPress);
            // 
            // UserControl_Favorites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.panel_video);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserControl_Favorites";
            this.Size = new System.Drawing.Size(923, 708);
            this.Load += new System.EventHandler(this.UserControl_Favorites_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton button_search;
        private System.Windows.Forms.Panel panel_video;
        private System.Windows.Forms.TextBox Textbox_search;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
    }
}
