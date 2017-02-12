using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemtentaTdd2017.blog
{
    public interface IAuthenticator
    {
        // Searches database for *username*.
        // Returns null if no valid user-object is found
        User GetUserFromDatabase(string username);
    }
}
