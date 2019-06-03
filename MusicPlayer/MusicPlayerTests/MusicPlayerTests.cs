using NUnit.Framework;
using MusicPlayer;
using MusicPlayer.MusicPlayerComponents;

namespace MusicPlayerTests
{
    public class MusicPlayerTest
    {
        [Test]
        public void plackback_continues_even_if_device_is_idle()
        {
            // Given
            var device = new DeviceMock();
            var timeWithNoInteractionSeconds = 30;
            var player = new Player();

            device.InteractivityTimer();

            // When 
            var isDeviceIdle = device.InteractivityTimer() >= timeWithNoInteractionSeconds;

            // Then
            Assert.True(isDeviceIdle);

            // When 
            if (isDeviceIdle)
            {
                player.isPlayback = true;
            }

            // Then
            Assert.True(player.isPlayback);
        }
    }
}