using MusicPlayer;
using MusicPlayer.MusicPlayerComponents;

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
    }
}
