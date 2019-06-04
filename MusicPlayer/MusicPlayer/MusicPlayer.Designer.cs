namespace MusicPlayer
{
    partial class MusicPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayer));
            this.PlayButton = new System.Windows.Forms.Button();
            this.SelectMediaFiles = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SkipToNextSong = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlayButton.BackgroundImage")));
            this.PlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PlayButton.Location = new System.Drawing.Point(221, 205);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(43, 43);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButtonClicked);
            // 
            // SelectMediaFiles
            // 
            this.SelectMediaFiles.Location = new System.Drawing.Point(14, 269);
            this.SelectMediaFiles.Name = "SelectMediaFiles";
            this.SelectMediaFiles.Size = new System.Drawing.Size(190, 40);
            this.SelectMediaFiles.TabIndex = 1;
            this.SelectMediaFiles.Text = "Select Album";
            this.SelectMediaFiles.UseVisualStyleBackColor = true;
            this.SelectMediaFiles.Click += new System.EventHandler(this.SelectMusicFiles);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SkipToNextSong);
            this.panel1.Controls.Add(this.PlayButton);
            this.panel1.Location = new System.Drawing.Point(14, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 251);
            this.panel1.TabIndex = 2;
            // 
            // SkipToNextSong
            // 
            this.SkipToNextSong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SkipToNextSong.BackgroundImage")));
            this.SkipToNextSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SkipToNextSong.Location = new System.Drawing.Point(270, 205);
            this.SkipToNextSong.Name = "SkipToNextSong";
            this.SkipToNextSong.Size = new System.Drawing.Size(43, 43);
            this.SkipToNextSong.TabIndex = 1;
            this.SkipToNextSong.UseVisualStyleBackColor = true;
            this.SkipToNextSong.Click += new System.EventHandler(this.SkipButtonClicked);
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 321);
            this.Controls.Add(this.SelectMediaFiles);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MusicPlayer";
            this.Text = "Music Player";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button SelectMediaFiles;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SkipToNextSong;
    }
}

