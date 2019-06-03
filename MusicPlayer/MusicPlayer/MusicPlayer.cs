using MusicPlayer.MusicPlayerComponents;
using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class MusicPlayer : Form
    {
        public MusicPlayer()
        {
            InitializeComponent();
            
        }

        private DeviceMock _mDevice = new DeviceMock();
        private Player _mPlayer = new Player();

        public List<string> filesSelected = new List<string>();

        private void PlayButtonClicked(object sender, EventArgs e)
        {
            _mDevice.aButtonIsPressed = true;
            _mPlayer.PlaySong(filesSelected);
        }

        private void SelectMusicFiles(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\Code\MusicPlayerSynopticProject\MusicLibrary",
                Title = "Browse Audio Files",

                CheckFileExists = true,
                CheckPathExists = true,
                RestoreDirectory = true,

                Multiselect = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < openFileDialog1.FileNames.Length; i++ )
                {
                    filesSelected.Add(openFileDialog1.FileNames[i].ToString());
                }
            }
        }
    }
}
