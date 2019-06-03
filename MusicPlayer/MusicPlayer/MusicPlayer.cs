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
            SoundPlayer songSelected = new SoundPlayer(@"c:\Windows\Media\chord.wav");
            songSelected.Play();
        }
    }
}
