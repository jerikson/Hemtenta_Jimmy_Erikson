using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemtentaTdd2017.blog
{

    public class Page
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public User Author { get; private set; } // Do not allow user to change Author?
        public DateTime Published { get; set; } // Allow user to change date?

        public Page(User author, string title, string content)
        {
            this.Author = author;
            this.Title = title;
            this.Content = content;
            this.Published = DateTime.Now;
        }
    }

}
