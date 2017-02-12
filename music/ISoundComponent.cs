using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemtentaTdd2017.music
{
    // Plays music, implement or mock
    public interface ISoundComponent
    {
        // Titel of song being played, empty if none playing
        string NowPlaying { get; }
        void Play(ISong song);
        void Stop();
    }
}
