using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemtentaTdd2017.music
{
    // Represents audiofile and metadata
    // Implement or mock..
    public interface ISong
    {
        string Title { get; }
        string Artist { get;  }
        //string[] Lyrics { get; }
        int Length { get; }
        string Format { get; }
    }
}
