using System;
using System.Collections.Generic;
using System.Linq;

namespace HemtentaTdd2017.music
{
    public class MediaDatabase : IMediaDatabase
    {
        public bool IsConnected { get; set; }
        readonly List<ISong> _mediaLibrary;

        public MediaDatabase()
        {
            _mediaLibrary = new List<ISong>()
            {
                new Song("A_track", 120, "mp3"),
                new Song("B_track", 201, "mp4"),
                new Song("C_track", 124, "WAV")
            };
        }

        public void OpenConnection()
        {
            if (IsConnected)
            {
                throw new DatabaseAlreadyOpenException();
            }
            else
            {
                IsConnected = true;
            }
        }

        public void CloseConnection()
        {
            if (IsConnected)
            {
                IsConnected = false;
            }
            else
            {
                throw new DatabaseClosedException();
            }
        }

        public List<ISong> FetchSongs(string search)
        {
            List<ISong> tmp = new List<ISong>();

            if (string.IsNullOrWhiteSpace(search))
            {
                throw new NullReferenceException("FetchSongs: search string is null or empty");
            }
            if (IsConnected)
            {
                tmp.AddRange(_mediaLibrary.ToList().Cast<Song>()
                    .Where(song => song.Title.Contains(search)).Cast<ISong>());
            }
            else { throw new DatabaseClosedException(); }

            return tmp;
        }



    }
}