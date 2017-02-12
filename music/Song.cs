using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemtentaTdd2017.music
{
    public class Song : ISong
    {
        public string Artist { get; set; }
        public string Title { get; set; }
        public int Length { get; set; }
        public string Format { get; set; }

        public Song(string title, int length, string format)
        {
            Title = title;
            Length = length;
            Format = format;
        }

    }
}
