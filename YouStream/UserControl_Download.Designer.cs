using System;

namespace YouStream
{
    partial class UserControl_Download
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Download));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Textbox_search = new System.Windows.Forms.TextBox();
            this.button_search = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Textbox_search2 = new Bunifu.Framework.UI.BunifuTextbox();
            this.panel_video = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.Textbox_search);
            this.panel1.Controls.Add(this.button_search);
            this.panel1.Controls.Add(this.Textbox_search2);
            this.panel1.Location = new System.Drawing.Point(4, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 94);
            this.panel1.TabIndex = 1;
            // 
            // Textbox_search
            // 
            this.Textbox_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Textbox_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Textbox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_search.ForeColor = System.Drawing.Color.Orange;
            this.Textbox_search.Location = new System.Drawing.Point(66, 32);
            this.Textbox_search.Name = "Textbox_search";
            this.Textbox_search.Size = new System.Drawing.Size(485, 27);
            this.Textbox_search.TabIndex = 0;
            this.Textbox_search.TabStop = false;
            this.Textbox_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textbox_search_KeyPress);
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
            this.button_search.Margin = new System.Windows.Forms.Padding(5);
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
            // Textbox_search2
            // 
            this.Textbox_search2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Textbox_search2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Textbox_search2.BackgroundImage")));
            this.Textbox_search2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Textbox_search2.Enabled = false;
            this.Textbox_search2.ForeColor = System.Drawing.Color.DarkOrange;
            this.Textbox_search2.Icon = ((System.Drawing.Image)(resources.GetObject("Textbox_search2.Icon")));
            this.Textbox_search2.Location = new System.Drawing.Point(20, 20);
            this.Textbox_search2.Margin = new System.Windows.Forms.Padding(5);
            this.Textbox_search2.Name = "Textbox_search2";
            this.Textbox_search2.Size = new System.Drawing.Size(543, 52);
            this.Textbox_search2.TabIndex = 0;
            this.Textbox_search2.TabStop = false;
            this.Textbox_search2.text = "";
            // 
            // panel_video
            // 
            this.panel_video.AutoScroll = true;
            this.panel_video.Location = new System.Drawing.Point(4, 101);
            this.panel_video.Margin = new System.Windows.Forms.Padding(4);
            this.panel_video.Name = "panel_video";
            this.panel_video.Size = new System.Drawing.Size(919, 613);
            this.panel_video.TabIndex = 2;
            // 
            // UserControl_Download
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.panel_video);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControl_Download";
            this.Size = new System.Drawing.Size(923, 718);
            this.Tag = "";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTextbox Textbox_search2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton button_search;
        private System.Windows.Forms.Panel panel_video;
        private System.Windows.Forms.TextBox Textbox_search;
    }
}
