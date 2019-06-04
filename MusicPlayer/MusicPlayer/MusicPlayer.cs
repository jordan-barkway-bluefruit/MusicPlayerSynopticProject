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

        int songNumber = 0;

        private DeviceMock _mDevice = new DeviceMock();
        private Player _mPlayer = new Player();

        public List<string> filesSelected = new List<string>();
               

        private void PlayButtonClicked(object sender, EventArgs e)
        {
            _mDevice.aButtonIsPressed = true;
            _mPlayer.PlaySong(filesSelected);

            songTitleDisplay.Text = filesSelected[songNumber].ToString().Substring(48);
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

                for (int i = 0; i < files.Length; i++ )
                {
                    filesSelected.Add(files[i].ToString());
                }
            }

            albumTitleDisplay.Text = folderBrowserDialog1.SelectedPath.ToString().Substring(48);

            SelectMediaFiles.Hide();
            panel1.Show();
        }

        private void SkipButtonClicked(object sender, EventArgs e)
        {
            _mDevice.aButtonIsPressed = true;
            _mPlayer.SkipSong();

            songTitleDisplay.Text = filesSelected[++songNumber].ToString().Substring(48);
        }

        private void PreviousButtonClicked(object sender, EventArgs e)
        {
            _mDevice.aButtonIsPressed = true;
            _mPlayer.PreviousSong();

            songTitleDisplay.Text = filesSelected[--songNumber].ToString().Substring(48);
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
