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
        public bool shuffleActive = false;

        static readonly WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        private WMPLib.IWMPPlaylist playlist = wplayer.newPlaylist("My playlist", "");

        public void PlaySong(List<string> filesSelected)
        {
            if (_mDevice.InteractivityTimer())
            {
                isPlayback = true;
            }

            if (isPlayback)
            {
                for (int i = 0; i < filesSelected.Count; i++)
                {
                    playlist.appendItem(wplayer.newMedia(filesSelected[i].Replace(@"\\", @"\")));
                }

                wplayer.currentPlaylist = playlist;
                wplayer.settings.setMode("loop", true);
                wplayer.settings.setMode("shuffle", shuffleActive);
                wplayer.controls.play();
            }
        }

        public void SkipSong()
        {
            wplayer.controls.next();
        }

        public void PreviousSong()
        {
            wplayer.controls.previous();
        }

        public void PauseSong()
        {
            wplayer.controls.pause();
        }
    }
}
