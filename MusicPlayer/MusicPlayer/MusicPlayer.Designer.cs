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
            this.previousButton = new System.Windows.Forms.Button();
            this.songTitleDisplay = new System.Windows.Forms.Label();
            this.SkipToNextSong = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.songTitleLabel = new System.Windows.Forms.Label();
            this.albumTitleLabel = new System.Windows.Forms.Label();
            this.albumTitleDisplay = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlayButton.BackgroundImage")));
            this.PlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PlayButton.Location = new System.Drawing.Point(221, 187);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(43, 43);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButtonClicked);
            // 
            // SelectMediaFiles
            // 
            this.SelectMediaFiles.Location = new System.Drawing.Point(14, 251);
            this.SelectMediaFiles.Name = "SelectMediaFiles";
            this.SelectMediaFiles.Size = new System.Drawing.Size(190, 40);
            this.SelectMediaFiles.TabIndex = 1;
            this.SelectMediaFiles.Text = "Select Album";
            this.SelectMediaFiles.UseVisualStyleBackColor = true;
            this.SelectMediaFiles.Click += new System.EventHandler(this.SelectMusicFiles);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.albumTitleDisplay);
            this.panel1.Controls.Add(this.albumTitleLabel);
            this.panel1.Controls.Add(this.songTitleLabel);
            this.panel1.Controls.Add(this.pauseButton);
            this.panel1.Controls.Add(this.previousButton);
            this.panel1.Controls.Add(this.songTitleDisplay);
            this.panel1.Controls.Add(this.SkipToNextSong);
            this.panel1.Controls.Add(this.PlayButton);
            this.panel1.Location = new System.Drawing.Point(14, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 233);
            this.panel1.TabIndex = 2;
            // 
            // previousButton
            // 
            this.previousButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("previousButton.BackgroundImage")));
            this.previousButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.previousButton.Location = new System.Drawing.Point(123, 187);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(43, 43);
            this.previousButton.TabIndex = 4;
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.PreviousButtonClicked);
            // 
            // songTitleDisplay
            // 
            this.songTitleDisplay.AutoSize = true;
            this.songTitleDisplay.Location = new System.Drawing.Point(84, 18);
            this.songTitleDisplay.Name = "songTitleDisplay";
            this.songTitleDisplay.Size = new System.Drawing.Size(0, 13);
            this.songTitleDisplay.TabIndex = 3;
            // 
            // SkipToNextSong
            // 
            this.SkipToNextSong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SkipToNextSong.BackgroundImage")));
            this.SkipToNextSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SkipToNextSong.Location = new System.Drawing.Point(270, 187);
            this.SkipToNextSong.Name = "SkipToNextSong";
            this.SkipToNextSong.Size = new System.Drawing.Size(43, 43);
            this.SkipToNextSong.TabIndex = 1;
            this.SkipToNextSong.UseVisualStyleBackColor = true;
            this.SkipToNextSong.Click += new System.EventHandler(this.SkipButtonClicked);
            // 
            // pauseButton
            // 
            this.pauseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pauseButton.BackgroundImage")));
            this.pauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pauseButton.Location = new System.Drawing.Point(172, 187);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(43, 43);
            this.pauseButton.TabIndex = 5;
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.PauseButtonClicked);
            // 
            // songTitleLabel
            // 
            this.songTitleLabel.AutoSize = true;
            this.songTitleLabel.Location = new System.Drawing.Point(14, 18);
            this.songTitleLabel.Name = "songTitleLabel";
            this.songTitleLabel.Size = new System.Drawing.Size(57, 13);
            this.songTitleLabel.TabIndex = 6;
            this.songTitleLabel.Text = "Song title: ";
            // 
            // albumTitleLabel
            // 
            this.albumTitleLabel.AutoSize = true;
            this.albumTitleLabel.Location = new System.Drawing.Point(17, 56);
            this.albumTitleLabel.Name = "albumTitleLabel";
            this.albumTitleLabel.Size = new System.Drawing.Size(61, 13);
            this.albumTitleLabel.TabIndex = 7;
            this.albumTitleLabel.Text = "Album title: ";
            // 
            // albumTitleDisplay
            // 
            this.albumTitleDisplay.AutoSize = true;
            this.albumTitleDisplay.Location = new System.Drawing.Point(85, 56);
            this.albumTitleDisplay.Name = "albumTitleDisplay";
            this.albumTitleDisplay.Size = new System.Drawing.Size(0, 13);
            this.albumTitleDisplay.TabIndex = 8;
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 296);
            this.Controls.Add(this.SelectMediaFiles);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MusicPlayer";
            this.Text = "Music Player";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button SelectMediaFiles;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SkipToNextSong;
        private System.Windows.Forms.Label songTitleDisplay;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Label albumTitleLabel;
        private System.Windows.Forms.Label songTitleLabel;
        private System.Windows.Forms.Label albumTitleDisplay;
    }
}

