using MusicPlayer.MusicPlayerComponents;
using System;
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

        private void PlayButtonClicked(object sender, EventArgs e)
        {
            _mDevice.aButtonIsPressed = true;
            _mPlayer.PlaySong();
        }
    }
}
