using NUnit.Framework;
using MusicPlayer;
using MusicPlayerTests.Mocks;

namespace MusicPlayerTests
{
    public class MusicPlayerTest
    {
        [Test]
        public void plackback_continues_even_if_device_is_idle()
        {
            // Given a device 
            var device = new DeviceMock();
            var mockPlayer = new MockPlayer();

            // When a song is playing and no buttons are pressed for 30 seconds
            mockPlayer.PlaySong();

            // Then the device carrys on playing music
            Assert.True(mockPlayer.isPlayback);
        }
    }
}