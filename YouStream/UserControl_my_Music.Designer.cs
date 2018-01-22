namespace YouStream
{
    partial class UserControl_my_Music
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
            this.panel_my_music = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel_my_music
            // 
            this.panel_my_music.Location = new System.Drawing.Point(0, 93);
            this.panel_my_music.Name = "panel_my_music";
            this.panel_my_music.Size = new System.Drawing.Size(692, 490);
            this.panel_my_music.TabIndex = 0;
            // 
            // UserControl_my_Music
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.panel_my_music);
            this.Name = "UserControl_my_Music";
            this.Size = new System.Drawing.Size(692, 583);
            this.Load += new System.EventHandler(this.UserControl_my_Music_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_my_music;
    }
}
