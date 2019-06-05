using MusicPlayer.MusicPlayerComponents;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class MusicPlayer : Form
    {
        public MusicPlayer()
        {
            InitializeComponent();

            panel1.Hide();
        }
        
        private DeviceMock _mDevice = new DeviceMock();
        private Player _mPlayer = new Player();

        public List<string> filesSelected = new List<string>();
               

        private void PlayButtonClicked(object sender, EventArgs e)
        {
            _mDevice.aButtonIsPressed = true;
            _mPlayer.PlaySong();
        }

        private void SelectMusicFiles(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog
            {
                RootFolder = Environment.SpecialFolder.MyComputer
            };

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);

                for(int file = 1; file < files.Length; file++)
                {
                    if (files[file - 1].ToString().EndsWith(".mp3"))
                    {
                            filesSelected.Add(files[file].ToString());
                            albumTitleDisplay.Text = folderBrowserDialog1.SelectedPath.ToString().Substring(48);
                            _mPlayer.PlayListCreation(filesSelected);

                            SelectMediaFiles.Hide();
                            panel1.Show();
                    }
                    else
                    {
                        MessageBox.Show("Please select a different folder that contains MP3 files.");
                        SelectMusicFiles(sender, e);
                    }
                }
                 
            }
        }

        private void SkipButtonClicked(object sender, EventArgs e)
        {
            _mDevice.aButtonIsPressed = true;
            _mPlayer.SkipSong();
        }

        private void PreviousButtonClicked(object sender, EventArgs e)
        {
            _mDevice.aButtonIsPressed = true;
            _mPlayer.PreviousSong();
        }

        private void PauseButtonClicked(object sender, EventArgs e)
        {
            _mDevice.aButtonIsPressed = true;
            _mPlayer.PauseSong();
        }

        private void ShuffleButtonClicked(object sender, EventArgs e)
        {
            _mPlayer.shuffleActive = true;
        }
    }
}
