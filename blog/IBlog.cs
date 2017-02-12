using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HemtentaTdd2017.blog;

namespace HemtentaTdd2017
{
    public interface IBlog
    {
        // login user, null if it fails
        // throws exception
        void LoginUser(User u);

        // logout user
        // exception if User is null.
        void LogoutUser(User u);

        bool UserIsLoggedIn { get; }

        bool PublishPage(Page p);
        // Returnerar 1 if valid, else 0
        int SendEmail(string address, string caption, string body);


    }
}
