using System.Collections.Generic;

namespace MusicPlayer.MusicPlayerComponents
{
    public interface IPlayer
    {
        void PlaySong();
        void SkipSong();
        void PlayListCreation(List<string> filesSelected);
        void PreviousSong();
        void PauseSong();
    }
}
