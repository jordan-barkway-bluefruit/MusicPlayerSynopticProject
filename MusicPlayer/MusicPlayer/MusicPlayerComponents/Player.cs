using System.Collections.Generic;
using System.Media;

namespace MusicPlayer.MusicPlayerComponents
{
    public class Player : IPlayer
    {
        public Player()
        { }

        public DeviceMock _mDevice = new DeviceMock();

        public bool isPlayback = false;

        public void PlaySong(List<string> filesSelected)
        {
            if (_mDevice.InteractivityTimer())
            {
                isPlayback = true;
            }

            if (isPlayback)
            {
                WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

                for (int i = 0; i < filesSelected.Count; i++)
                {
                    wplayer.URL = filesSelected[i].Replace(@"\\", @"\");
                    wplayer.controls.play();
                }
                
            }
        }
    }
}
