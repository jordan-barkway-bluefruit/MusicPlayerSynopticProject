using System;
using System.Collections.Generic;

namespace MusicPlayer.MusicPlayerComponents
{
    public class Player : IPlayer
    {
        public Player()
        { }

        public DeviceMock _mDevice = new DeviceMock();

        public bool shuffleActive = false;

        static readonly WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        private WMPLib.IWMPPlaylist playlist = wplayer.newPlaylist("My playlist", "");

        public void PlayListCreation(List<string> filesSelected)
        {
            for (int i = 0; i < filesSelected.Count; i++)
            {
                playlist.appendItem(wplayer.newMedia(filesSelected[i].Replace(@"\\", @"\")));
            }

            wplayer.currentPlaylist = playlist;
        }

        public void PlaySong()
        {
            wplayer.settings.setMode("shuffle", shuffleActive);
            wplayer.controls.play();
        }

        public void SkipSong()
        {
            wplayer.settings.setMode("shuffle", shuffleActive);
            wplayer.controls.next();
        }

        public void PreviousSong()
        {
            wplayer.settings.setMode("shuffle", shuffleActive);
            wplayer.controls.previous();
        }

        public void PauseSong()
        {
            wplayer.settings.setMode("shuffle", shuffleActive);
            wplayer.controls.pause();
        }
    }
}
