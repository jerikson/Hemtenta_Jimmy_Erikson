using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemtentaTdd2017.music
{
    public interface IMusicPlayer
    {
        // Total tracks in playlist, always returns prime >=0
        int NumSongsInQueue { get; }

        // Searches db for song titles containing *search*, add all results to playlist
        void LoadSongs(string search);

        // If no track is being played, play next track in queue 
        void Play();

        // If a track is being played, stop playing
        void Stop();

        // Start next track in queue, if queue is empty, - Stop()
        void NextSong();

        // Returns "Now playing <title>, if nothing plays, return "precense of silence"
        string NowPlaying();
    }
}
