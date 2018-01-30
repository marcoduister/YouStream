namespace YouStream
{
    partial class UserControlVolumeControl
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
            this.Slider_Volume = new Bunifu.Framework.UI.BunifuSlider();
            this.Label_Volume = new System.Windows.Forms.Label();
            this.ButtonVolumeMute = new Bunifu.Framework.UI.BunifuImageButton();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.TimerButtonImage = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ButtonVolumeMute)).BeginInit();
            this.SuspendLayout();
            // 
            // Slider_Volume
            // 
            this.Slider_Volume.BackColor = System.Drawing.Color.Transparent;
            this.Slider_Volume.BackgroudColor = System.Drawing.Color.White;
            this.Slider_Volume.BorderRadius = 0;
            this.Slider_Volume.IndicatorColor = System.Drawing.Color.Orange;
            this.Slider_Volume.Location = new System.Drawing.Point(97, 59);
            this.Slider_Volume.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Slider_Volume.MaximumValue = 100;
            this.Slider_Volume.Name = "Slider_Volume";
            this.Slider_Volume.Size = new System.Drawing.Size(200, 35);
            this.Slider_Volume.TabIndex = 15;
            this.Slider_Volume.Value = 0;
            this.Slider_Volume.ValueChanged += new System.EventHandler(this.Slider_Volume_ValueChanged);
            // 
            // Label_Volume
            // 
            this.Label_Volume.AutoSize = true;
            this.Label_Volume.BackColor = System.Drawing.Color.Transparent;
            this.Label_Volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Volume.ForeColor = System.Drawing.Color.White;
            this.Label_Volume.Location = new System.Drawing.Point(297, 52);
            this.Label_Volume.MaximumSize = new System.Drawing.Size(85, 45);
            this.Label_Volume.MinimumSize = new System.Drawing.Size(85, 45);
            this.Label_Volume.Name = "Label_Volume";
            this.Label_Volume.Size = new System.Drawing.Size(85, 45);
            this.Label_Volume.TabIndex = 14;
            this.Label_Volume.Text = "100";
            this.Label_Volume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonVolumeMute
            // 
            this.ButtonVolumeMute.BackColor = System.Drawing.Color.Transparent;
            this.ButtonVolumeMute.ErrorImage = null;
            this.ButtonVolumeMute.Image = global::YouStream.Properties.Resources.No_Volume;
            this.ButtonVolumeMute.ImageActive = null;
            this.ButtonVolumeMute.InitialImage = null;
            this.ButtonVolumeMute.Location = new System.Drawing.Point(19, 45);
            this.ButtonVolumeMute.Name = "ButtonVolumeMute";
            this.ButtonVolumeMute.Size = new System.Drawing.Size(60, 60);
            this.ButtonVolumeMute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ButtonVolumeMute.TabIndex = 13;
            this.ButtonVolumeMute.TabStop = false;
            this.ButtonVolumeMute.Zoom = 10;
            this.ButtonVolumeMute.Click += new System.EventHandler(this.ButtonVolumeMute_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 5;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // TimerButtonImage
            // 
            this.TimerButtonImage.Interval = 50;
            this.TimerButtonImage.Tick += new System.EventHandler(this.TimerButtonImage_Tick);
            // 
            // UserControlVolumeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.Slider_Volume);
            this.Controls.Add(this.Label_Volume);
            this.Controls.Add(this.ButtonVolumeMute);
            this.Name = "UserControlVolumeControl";
            this.Size = new System.Drawing.Size(400, 150);
            ((System.ComponentModel.ISupportInitialize)(this.ButtonVolumeMute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuSlider Slider_Volume;
        private System.Windows.Forms.Label Label_Volume;
        private Bunifu.Framework.UI.BunifuImageButton ButtonVolumeMute;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Timer TimerButtonImage;
    }
}
