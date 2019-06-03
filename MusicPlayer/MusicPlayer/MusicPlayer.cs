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

        private void PlayButtonClicked(object sender, EventArgs e)
        {
            SoundPlayer songSelected = new SoundPlayer(@"C:\Code\MusicPlayerSynopticProject\MusicLibrary\Friday - Rebecca Black.wav");
            songSelected.Play();
        }
    }
}
