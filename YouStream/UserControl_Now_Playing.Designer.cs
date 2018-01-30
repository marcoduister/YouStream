namespace YouStream
{
    partial class UserControl_Now_Playing
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
            this.Panel_MusicControl = new System.Windows.Forms.Panel();
            this.Button_FastForward = new Bunifu.Framework.UI.BunifuImageButton();
            this.Button_FastBackward = new Bunifu.Framework.UI.BunifuImageButton();
            this.Button_PlayPause = new Bunifu.Framework.UI.BunifuImageButton();
            this.Label_CurrentTime = new System.Windows.Forms.Label();
            this.ProgressBar_MusicTIme = new Bunifu.Framework.UI.BunifuProgressBar();
            this.TimerSetPosition = new System.Windows.Forms.Timer(this.components);
            this.Label_MaximumTime = new System.Windows.Forms.Label();
            this.Panel_MusicControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Button_FastForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_FastBackward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_PlayPause)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_MusicControl
            // 
            this.Panel_MusicControl.BackColor = System.Drawing.Color.DarkOrange;
            this.Panel_MusicControl.Controls.Add(this.Button_FastForward);
            this.Panel_MusicControl.Controls.Add(this.Button_FastBackward);
            this.Panel_MusicControl.Controls.Add(this.Button_PlayPause);
            this.Panel_MusicControl.Location = new System.Drawing.Point(0, 608);
            this.Panel_MusicControl.Name = "Panel_MusicControl";
            this.Panel_MusicControl.Size = new System.Drawing.Size(923, 100);
            this.Panel_MusicControl.TabIndex = 0;
            // 
            // Button_FastForward
            // 
            this.Button_FastForward.BackColor = System.Drawing.Color.Transparent;
            this.Button_FastForward.ErrorImage = null;
            this.Button_FastForward.Image = global::YouStream.Properties.Resources.FastForward;
            this.Button_FastForward.ImageActive = null;
            this.Button_FastForward.InitialImage = null;
            this.Button_FastForward.Location = new System.Drawing.Point(186, 30);
            this.Button_FastForward.Name = "Button_FastForward";
            this.Button_FastForward.Size = new System.Drawing.Size(40, 40);
            this.Button_FastForward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Button_FastForward.TabIndex = 2;
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
            this.Button_FastBackward.Location = new System.Drawing.Point(54, 30);
            this.Button_FastBackward.Name = "Button_FastBackward";
            this.Button_FastBackward.Size = new System.Drawing.Size(40, 40);
            this.Button_FastBackward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Button_FastBackward.TabIndex = 1;
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
            this.Button_PlayPause.Location = new System.Drawing.Point(100, 10);
            this.Button_PlayPause.Name = "Button_PlayPause";
            this.Button_PlayPause.Size = new System.Drawing.Size(80, 80);
            this.Button_PlayPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Button_PlayPause.TabIndex = 0;
            this.Button_PlayPause.TabStop = false;
            this.Button_PlayPause.Zoom = 10;
            this.Button_PlayPause.Click += new System.EventHandler(this.Button_PlayPause_Click);
            // 
            // Label_CurrentTime
            // 
            this.Label_CurrentTime.AutoSize = true;
            this.Label_CurrentTime.ForeColor = System.Drawing.Color.Orange;
            this.Label_CurrentTime.Location = new System.Drawing.Point(10, 576);
            this.Label_CurrentTime.Name = "Label_CurrentTime";
            this.Label_CurrentTime.Size = new System.Drawing.Size(44, 17);
            this.Label_CurrentTime.TabIndex = 0;
            this.Label_CurrentTime.Text = "00:00";
            // 
            // ProgressBar_MusicTIme
            // 
            this.ProgressBar_MusicTIme.BackColor = System.Drawing.Color.Silver;
            this.ProgressBar_MusicTIme.BorderRadius = 5;
            this.ProgressBar_MusicTIme.Location = new System.Drawing.Point(0, 597);
            this.ProgressBar_MusicTIme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProgressBar_MusicTIme.MaximumValue = 100;
            this.ProgressBar_MusicTIme.Name = "ProgressBar_MusicTIme";
            this.ProgressBar_MusicTIme.ProgressColor = System.Drawing.Color.Black;
            this.ProgressBar_MusicTIme.Size = new System.Drawing.Size(923, 12);
            this.ProgressBar_MusicTIme.TabIndex = 0;
            this.ProgressBar_MusicTIme.TabStop = false;
            this.ProgressBar_MusicTIme.Value = 0;
            // 
            // TimerSetPosition
            // 
            this.TimerSetPosition.Interval = 1000;
            this.TimerSetPosition.Tick += new System.EventHandler(this.TimerSetPosition_Tick);
            // 
            // Label_MaximumTime
            // 
            this.Label_MaximumTime.AutoSize = true;
            this.Label_MaximumTime.ForeColor = System.Drawing.Color.Orange;
            this.Label_MaximumTime.Location = new System.Drawing.Point(869, 576);
            this.Label_MaximumTime.Name = "Label_MaximumTime";
            this.Label_MaximumTime.Size = new System.Drawing.Size(44, 17);
            this.Label_MaximumTime.TabIndex = 0;
            this.Label_MaximumTime.Text = "00:00";
            // 
            // UserControl_Now_Playing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.Label_MaximumTime);
            this.Controls.Add(this.Label_CurrentTime);
            this.Controls.Add(this.Panel_MusicControl);
            this.Controls.Add(this.ProgressBar_MusicTIme);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControl_Now_Playing";
            this.Size = new System.Drawing.Size(923, 708);
            this.Panel_MusicControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Button_FastForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_FastBackward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_PlayPause)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_MusicControl;
        private Bunifu.Framework.UI.BunifuImageButton Button_PlayPause;
        private Bunifu.Framework.UI.BunifuImageButton Button_FastForward;
        private Bunifu.Framework.UI.BunifuImageButton Button_FastBackward;
        private System.Windows.Forms.Timer TimerSetPosition;
        private Bunifu.Framework.UI.BunifuProgressBar ProgressBar_MusicTIme;
        private System.Windows.Forms.Label Label_CurrentTime;
        private System.Windows.Forms.Label Label_MaximumTime;
    }
}
