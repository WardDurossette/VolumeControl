namespace VolumeControl
{
    partial class frmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCurrentPlaybackVolume = new System.Windows.Forms.Label();
            this.btnSetPlaybackVolume = new System.Windows.Forms.Button();
            this.btnSetCaptureVolume = new System.Windows.Forms.Button();
            this.lblCurrentCaptureVolume = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCurrentPlaybackVolume
            // 
            this.lblCurrentPlaybackVolume.AutoSize = true;
            this.lblCurrentPlaybackVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPlaybackVolume.Location = new System.Drawing.Point(158, 121);
            this.lblCurrentPlaybackVolume.Name = "lblCurrentPlaybackVolume";
            this.lblCurrentPlaybackVolume.Size = new System.Drawing.Size(280, 24);
            this.lblCurrentPlaybackVolume.TabIndex = 0;
            this.lblCurrentPlaybackVolume.Text = "Current Playback Volume: 00";
            // 
            // btnSetPlaybackVolume
            // 
            this.btnSetPlaybackVolume.Location = new System.Drawing.Point(482, 121);
            this.btnSetPlaybackVolume.Name = "btnSetPlaybackVolume";
            this.btnSetPlaybackVolume.Size = new System.Drawing.Size(174, 23);
            this.btnSetPlaybackVolume.TabIndex = 1;
            this.btnSetPlaybackVolume.Text = "Set Playback Volume";
            this.btnSetPlaybackVolume.UseVisualStyleBackColor = true;
            this.btnSetPlaybackVolume.Click += new System.EventHandler(this.btnSetPlaybackVolume_Click);
            // 
            // btnSetCaptureVolume
            // 
            this.btnSetCaptureVolume.Location = new System.Drawing.Point(482, 225);
            this.btnSetCaptureVolume.Name = "btnSetCaptureVolume";
            this.btnSetCaptureVolume.Size = new System.Drawing.Size(174, 23);
            this.btnSetCaptureVolume.TabIndex = 3;
            this.btnSetCaptureVolume.Text = "Set Capture Volume";
            this.btnSetCaptureVolume.UseVisualStyleBackColor = true;
            this.btnSetCaptureVolume.Click += new System.EventHandler(this.btnSetCaptureVolume_Click);
            // 
            // lblCurrentCaptureVolume
            // 
            this.lblCurrentCaptureVolume.AutoSize = true;
            this.lblCurrentCaptureVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentCaptureVolume.Location = new System.Drawing.Point(158, 225);
            this.lblCurrentCaptureVolume.Name = "lblCurrentCaptureVolume";
            this.lblCurrentCaptureVolume.Size = new System.Drawing.Size(270, 24);
            this.lblCurrentCaptureVolume.TabIndex = 2;
            this.lblCurrentCaptureVolume.Text = "Current Capture Volume: 00";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSetCaptureVolume);
            this.Controls.Add(this.lblCurrentCaptureVolume);
            this.Controls.Add(this.btnSetPlaybackVolume);
            this.Controls.Add(this.lblCurrentPlaybackVolume);
            this.Name = "frmMain";
            this.Text = "Volume Master";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentPlaybackVolume;
        private System.Windows.Forms.Button btnSetPlaybackVolume;
        private System.Windows.Forms.Button btnSetCaptureVolume;
        private System.Windows.Forms.Label lblCurrentCaptureVolume;
    }
}

