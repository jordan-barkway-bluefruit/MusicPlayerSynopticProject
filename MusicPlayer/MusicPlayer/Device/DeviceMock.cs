using System;

namespace MusicPlayer
{
    public class DeviceMock
    {
        public DeviceMock()
        { }
        
        public bool aButtonIsPressed = false;

        public bool InteractivityTimer()
        {
            DateTime currentDate = DateTime.Now;
            var afterThirtySeconds =  currentDate.AddSeconds(30);

            while (aButtonIsPressed)
            {
                if ((afterThirtySeconds >= DateTime.Now))
                {
                    return false;
                }

                return true;
            }

            return true;
        }
    }
}
