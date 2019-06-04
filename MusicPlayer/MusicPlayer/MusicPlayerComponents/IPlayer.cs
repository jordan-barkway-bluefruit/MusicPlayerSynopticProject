using System.Collections.Generic;

namespace MusicPlayer.MusicPlayerComponents
{
    public interface IPlayer
    {
        void PlaySong(List<string> filesSelected);
        void SkipSong();

    }
}
