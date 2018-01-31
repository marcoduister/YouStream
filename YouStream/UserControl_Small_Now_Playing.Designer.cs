namespace YouStream
{
    partial class UserControl_Small_Now_Playing
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
            this.components = new System.ComponentModel.Container();
            this.ProgressBar_Volume = new Bunifu.Framework.UI.BunifuProgressBar();
            this.PictureBox_Volume = new System.Windows.Forms.PictureBox();
            this.Label_MaximimTime = new System.Windows.Forms.Label();
            this.Label_CurrentTime = new System.Windows.Forms.Label();
            this.Button_FastForward = new Bunifu.Framework.UI.BunifuImageButton();
            this.Button_FastBackward = new Bunifu.Framework.UI.BunifuImageButton();
            this.Button_PlayPause = new Bunifu.Framework.UI.BunifuImageButton();
            this.ProgressBar_MusicTime = new Bunifu.Framework.UI.BunifuProgressBar();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_FastForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_FastBackward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_PlayPause)).BeginInit();
            this.SuspendLayout();
            // 
            // ProgressBar_Volume
            // 
            this.ProgressBar_Volume.BackColor = System.Drawing.Color.Silver;
            this.ProgressBar_Volume.BorderRadius = 5;
            this.ProgressBar_Volume.Location = new System.Drawing.Point(852, 31);
            this.ProgressBar_Volume.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProgressBar_Volume.MaximumValue = 100;
            this.ProgressBar_Volume.Name = "ProgressBar_Volume";
            this.ProgressBar_Volume.ProgressColor = System.Drawing.Color.DarkOrange;
            this.ProgressBar_Volume.Size = new System.Drawing.Size(136, 12);
            this.ProgressBar_Volume.TabIndex = 10;
            this.ProgressBar_Volume.TabStop = false;
            this.ProgressBar_Volume.Value = 0;
            this.ProgressBar_Volume.Click += new System.EventHandler(this.ProgressBar_Volume_Click);
            this.ProgressBar_Volume.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProgressBar_Volume_MouseClick);
            this.ProgressBar_Volume.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBar_Volume_MouseDown);
            // 
            // PictureBox_Volume
            // 
            this.PictureBox_Volume.ErrorImage = null;
            this.PictureBox_Volume.Image = global::YouStream.Properties.Resources.Volume_Icon;
            this.PictureBox_Volume.InitialImage = null;
            this.PictureBox_Volume.Location = new System.Drawing.Point(805, 18);
            this.PictureBox_Volume.Name = "PictureBox_Volume";
            this.PictureBox_Volume.Size = new System.Drawing.Size(40, 40);
            this.PictureBox_Volume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBox_Volume.TabIndex = 17;
            this.PictureBox_Volume.TabStop = false;
            // 
            // Label_MaximimTime
            // 
            this.Label_MaximimTime.AutoSize = true;
            this.Label_MaximimTime.ForeColor = System.Drawing.Color.Orange;
            this.Label_MaximimTime.Location = new System.Drawing.Point(746, 28);
            this.Label_MaximimTime.Name = "Label_MaximimTime";
            this.Label_MaximimTime.Size = new System.Drawing.Size(44, 17);
            this.Label_MaximimTime.TabIndex = 16;
            this.Label_MaximimTime.Text = "00:00";
            // 
            // Label_CurrentTime
            // 
            this.Label_CurrentTime.AutoSize = true;
            this.Label_CurrentTime.ForeColor = System.Drawing.Color.Orange;
            this.Label_CurrentTime.Location = new System.Drawing.Point(188, 28);
            this.Label_CurrentTime.Name = "Label_CurrentTime";
            this.Label_CurrentTime.Size = new System.Drawing.Size(44, 17);
            this.Label_CurrentTime.TabIndex = 15;
            this.Label_CurrentTime.Text = "00:00";
            // 
            // Button_FastForward
            // 
            this.Button_FastForward.BackColor = System.Drawing.Color.Transparent;
            this.Button_FastForward.ErrorImage = null;
            this.Button_FastForward.Image = global::YouStream.Properties.Resources.FastForward;
            this.Button_FastForward.ImageActive = null;
            this.Button_FastForward.InitialImage = null;
            this.Button_FastForward.Location = new System.Drawing.Point(137, 18);
            this.Button_FastForward.Name = "Button_FastForward";
            this.Button_FastForward.Size = new System.Drawing.Size(40, 40);
            this.Button_FastForward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Button_FastForward.TabIndex = 14;
            this.Button_FastForward.TabStop = false;
            this.Button_FastForward.Zoom = 10;
            this.Button_FastForward.Click += new System.EventHandler(this.Button_FastForward_Click);
            // 
            // Button_FastBackward
            // 
            this.Button_FastBackward.BackColor = System.Drawing.Color.Transparent;
            this.Button_FastBackward.ErrorImage = null;
            this.Button_FastBackward.Image = global::YouStream.Properties.Resources.FastBackward;
            this.Button_FastBackward.ImageActive = null;
            this.Button_FastBackward.InitialImage = null;
            this.Button_FastBackward.Location = new System.Drawing.Point(13, 18);
            this.Button_FastBackward.Name = "Button_FastBackward";
            this.Button_FastBackward.Size = new System.Drawing.Size(40, 40);
            this.Button_FastBackward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Button_FastBackward.TabIndex = 13;
            this.Button_FastBackward.TabStop = false;
            this.Button_FastBackward.Zoom = 10;
            this.Button_FastBackward.Click += new System.EventHandler(this.Button_FastBackward_Click);
            // 
            // Button_PlayPause
            // 
            this.Button_PlayPause.BackColor = System.Drawing.Color.Transparent;
            this.Button_PlayPause.ErrorImage = null;
            this.Button_PlayPause.Image = global::YouStream.Properties.Resources.Pauze;
            this.Button_PlayPause.ImageActive = null;
            this.Button_PlayPause.InitialImage = null;
            this.Button_PlayPause.Location = new System.Drawing.Point(59, 1);
            this.Button_PlayPause.Name = "Button_PlayPause";
            this.Button_PlayPause.Size = new System.Drawing.Size(72, 72);
            this.Button_PlayPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Button_PlayPause.TabIndex = 12;
            this.Button_PlayPause.TabStop = false;
            this.Button_PlayPause.Zoom = 10;
            this.Button_PlayPause.Click += new System.EventHandler(this.Button_PlayPause_Click);
            // 
            // ProgressBar_MusicTime
            // 
            this.ProgressBar_MusicTime.BackColor = System.Drawing.Color.Silver;
            this.ProgressBar_MusicTime.BorderRadius = 5;
            this.ProgressBar_MusicTime.Location = new System.Drawing.Point(239, 31);
            this.ProgressBar_MusicTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProgressBar_MusicTime.MaximumValue = 100;
            this.ProgressBar_MusicTime.Name = "ProgressBar_MusicTime";
            this.ProgressBar_MusicTime.ProgressColor = System.Drawing.Color.Orange;
            this.ProgressBar_MusicTime.Size = new System.Drawing.Size(500, 12);
            this.ProgressBar_MusicTime.TabIndex = 11;
            this.ProgressBar_MusicTime.TabStop = false;
            this.ProgressBar_MusicTime.Value = 0;
            // 
            // Timer
            // 
            this.Timer.Interval = 5;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // UserControl_Small_Now_Playing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.ProgressBar_Volume);
            this.Controls.Add(this.PictureBox_Volume);
            this.Controls.Add(this.Label_MaximimTime);
            this.Controls.Add(this.Label_CurrentTime);
            this.Controls.Add(this.Button_FastForward);
            this.Controls.Add(this.Button_FastBackward);
            this.Controls.Add(this.Button_PlayPause);
            this.Controls.Add(this.ProgressBar_MusicTime);
            this.Name = "UserControl_Small_Now_Playing";
            this.Size = new System.Drawing.Size(1000, 75);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_FastForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_FastBackward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_PlayPause)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuProgressBar ProgressBar_Volume;
        private System.Windows.Forms.PictureBox PictureBox_Volume;
        private System.Windows.Forms.Label Label_MaximimTime;
        private System.Windows.Forms.Label Label_CurrentTime;
        private Bunifu.Framework.UI.BunifuImageButton Button_FastForward;
        private Bunifu.Framework.UI.BunifuImageButton Button_FastBackward;
        private Bunifu.Framework.UI.BunifuImageButton Button_PlayPause;
        private Bunifu.Framework.UI.BunifuProgressBar ProgressBar_MusicTime;
        private System.Windows.Forms.Timer Timer;
    }
}
