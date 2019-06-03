using System.Media;

namespace MusicPlayer.MusicPlayerComponents
{
    public class Player : IPlayer
    {
        public Player()
        { }

        public DeviceMock _mDevice = new DeviceMock();

        public bool isPlayback = false;

        public void PlaySong()
        {
            if (_mDevice.InteractivityTimer())
            {
                isPlayback = true;
            }

            if (isPlayback)
            {
                SoundPlayer songSelected = new SoundPlayer(@"C:\Code\MusicPlayerSynopticProject\MusicLibrary\Friday - Rebecca Black.wav");
                songSelected.Play();
            }
        }
    }
}
