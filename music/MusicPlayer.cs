using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HemtentaTdd2017.music
{
    public class MusicPlayer : IMusicPlayer
    {
        IMediaDatabase _mediaDb;
        ISoundComponent _soundComponent;
        List<ISong> SongsInQueue;

        public int NumSongsInQueue { get { return SongsInQueue.Count; } }

        public MusicPlayer(IMediaDatabase db, ISoundComponent sc)
        {
            SongsInQueue = new List<ISong>();
            _mediaDb = db;
            _soundComponent = sc;
            _mediaDb.OpenConnection();
        }

        public void Play()
        {
            // If have songs to play, and we are not already playing, play!
            if (string.IsNullOrWhiteSpace(_soundComponent.NowPlaying) && NumSongsInQueue > 0)
            {
                _soundComponent.Play(SongsInQueue.ElementAt(0)); 
            }
        }

        public void Stop()
        {
            // If a track is being played, allow stop
            if(!string.IsNullOrWhiteSpace(NowPlaying()))
            _soundComponent.Stop();
        }

        public void NextSong()
        {
            if (NumSongsInQueue > 0) {
                SongsInQueue.RemoveAt(0);
            }
            if (NumSongsInQueue > 1) {
                _soundComponent.Play(SongsInQueue.First());
            } else {
                _soundComponent.Stop();
                throw new IndexOutOfRangeException("No songs left queue");
            }
        }

        public string NowPlaying()
        {
            if (!string.IsNullOrEmpty(_soundComponent.NowPlaying))
                return _soundComponent.NowPlaying;
            else {
                return "*silence*";
            }
        }

        public void LoadSongs(string search)
        {
            if (!string.IsNullOrWhiteSpace(search))
            {
                // SongsInQueue = (_mediaDb.FetchSongs(search);
                SongsInQueue.AddRange(_mediaDb.FetchSongs(search));
            }
            else
            {
                throw new NullReferenceException("LoadSongs: search string is null empty");
            }
        }


    }
}
