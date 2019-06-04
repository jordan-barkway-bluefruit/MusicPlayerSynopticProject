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
            this.shuffleButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlayButton.BackgroundImage")));
            this.PlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayButton.Location = new System.Drawing.Point(215, 159);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(63, 61);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButtonClicked);
            // 
            // SelectMediaFiles
            // 
            this.SelectMediaFiles.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectMediaFiles.Location = new System.Drawing.Point(14, 251);
            this.SelectMediaFiles.Name = "SelectMediaFiles";
            this.SelectMediaFiles.Size = new System.Drawing.Size(146, 40);
            this.SelectMediaFiles.TabIndex = 1;
            this.SelectMediaFiles.Text = "Select Album";
            this.SelectMediaFiles.UseVisualStyleBackColor = true;
            this.SelectMediaFiles.Click += new System.EventHandler(this.SelectMusicFiles);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.shuffleButton);
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
            this.previousButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.previousButton.Location = new System.Drawing.Point(77, 159);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(63, 61);
            this.previousButton.TabIndex = 4;
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.PreviousButtonClicked);
            // 
            // songTitleDisplay
            // 
            this.songTitleDisplay.AutoSize = true;
            this.songTitleDisplay.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songTitleDisplay.Location = new System.Drawing.Point(139, 21);
            this.songTitleDisplay.Name = "songTitleDisplay";
            this.songTitleDisplay.Size = new System.Drawing.Size(102, 24);
            this.songTitleDisplay.TabIndex = 3;
            this.songTitleDisplay.Text = "Song Title";
            // 
            // SkipToNextSong
            // 
            this.SkipToNextSong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SkipToNextSong.BackgroundImage")));
            this.SkipToNextSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SkipToNextSong.Location = new System.Drawing.Point(284, 159);
            this.SkipToNextSong.Name = "SkipToNextSong";
            this.SkipToNextSong.Size = new System.Drawing.Size(63, 61);
            this.SkipToNextSong.TabIndex = 1;
            this.SkipToNextSong.UseVisualStyleBackColor = true;
            this.SkipToNextSong.Click += new System.EventHandler(this.SkipButtonClicked);
            // 
            // pauseButton
            // 
            this.pauseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pauseButton.BackgroundImage")));
            this.pauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pauseButton.Location = new System.Drawing.Point(146, 159);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(63, 61);
            this.pauseButton.TabIndex = 5;
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.PauseButtonClicked);
            // 
            // songTitleLabel
            // 
            this.songTitleLabel.AutoSize = true;
            this.songTitleLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songTitleLabel.Location = new System.Drawing.Point(24, 21);
            this.songTitleLabel.Name = "songTitleLabel";
            this.songTitleLabel.Size = new System.Drawing.Size(109, 24);
            this.songTitleLabel.TabIndex = 6;
            this.songTitleLabel.Text = "Song title: ";
            // 
            // albumTitleLabel
            // 
            this.albumTitleLabel.AutoSize = true;
            this.albumTitleLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumTitleLabel.Location = new System.Drawing.Point(17, 59);
            this.albumTitleLabel.Name = "albumTitleLabel";
            this.albumTitleLabel.Size = new System.Drawing.Size(116, 24);
            this.albumTitleLabel.TabIndex = 7;
            this.albumTitleLabel.Text = "Album title: ";
            // 
            // albumTitleDisplay
            // 
            this.albumTitleDisplay.AutoSize = true;
            this.albumTitleDisplay.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumTitleDisplay.Location = new System.Drawing.Point(139, 59);
            this.albumTitleDisplay.Name = "albumTitleDisplay";
            this.albumTitleDisplay.Size = new System.Drawing.Size(65, 24);
            this.albumTitleDisplay.TabIndex = 8;
            this.albumTitleDisplay.Text = "Album";
            // 
            // shuffleButton
            // 
            this.shuffleButton.BackColor = System.Drawing.Color.White;
            this.shuffleButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("shuffleButton.BackgroundImage")));
            this.shuffleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.shuffleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shuffleButton.Location = new System.Drawing.Point(353, 159);
            this.shuffleButton.Name = "shuffleButton";
            this.shuffleButton.Size = new System.Drawing.Size(63, 61);
            this.shuffleButton.TabIndex = 9;
            this.shuffleButton.UseVisualStyleBackColor = false;
            this.shuffleButton.Click += new System.EventHandler(this.ShuffleButtonClicked);
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
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
        private System.Windows.Forms.Button shuffleButton;
    }
}

