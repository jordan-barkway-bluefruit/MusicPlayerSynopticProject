using MusicPlayer;
using MusicPlayer.MusicPlayerComponents;
using System.Collections.Generic;

namespace MusicPlayerTests.Mocks
{
    public class MockPlayer : IPlayer
    {
        public DeviceMock _mDevice = new DeviceMock();

        public bool isPlayback = false;
        
        public void PlaySong(List<string> filesSelected)
        {
            filesSelected = null;

            if (_mDevice.InteractivityTimer())
            {
                isPlayback = true;
            }
        }
    }
}
