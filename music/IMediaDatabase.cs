using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemtentaTdd2017.music
{

    // Interacting with a closed db or trying to open an already existing connection, throws: "Will not be implemented"
    public interface IMediaDatabase
    {
        bool IsConnected { get; }

        // Connects to database
        void OpenConnection();

        // Closing / Disposing database connection
        void CloseConnection();

        // Returns all songs in database that matches search string
        // string.Contains(string)
        List<ISong> FetchSongs(string search);
    }

    // DB class throws these when specified
    public class DatabaseClosedException : Exception { }
    public class DatabaseAlreadyOpenException : Exception { }
}
