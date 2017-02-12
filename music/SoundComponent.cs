using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using HemtentaTdd2017.music;

namespace HemtentaTdd2017.music
{
    public class SoundComponent : ISoundComponent
    {
        List<string> _compabillity;
        public string NowPlaying { get; private set; }

        public SoundComponent()
        {
            _compabillity = new List<string> {"mp3", "WAV"};
            NowPlaying = "";
        }
        public void Play(ISong song)
        {
            if (song != null)
            {
                NowPlaying = song.Title;
            } else
            {
                throw new NullReferenceException("Play: song is null");
            }
        }

        public void Stop() => NowPlaying = "";
    }
}

//to_do:
//_compabillity.Contains(song.Format)
