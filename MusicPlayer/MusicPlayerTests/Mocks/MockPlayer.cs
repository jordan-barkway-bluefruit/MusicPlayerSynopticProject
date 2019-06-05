using MusicPlayer;
using MusicPlayer.MusicPlayerComponents;
using System.Collections.Generic;

namespace MusicPlayerTests.Mocks
{
    public class MockPlayer : IPlayer
    {
        public DeviceMock _mDevice = new DeviceMock();

        public bool isPlayback = false;
        
        public void PlaySong()
        {
            if (_mDevice.InteractivityTimer())
            {
                isPlayback = true;
            }
        }

        public void PlayListCreation(List<string> filesSelected)
        { }
        public void SkipSong()
        { }
        public void PreviousSong()
        { }
        public void PauseSong()
        { }
    }
}
