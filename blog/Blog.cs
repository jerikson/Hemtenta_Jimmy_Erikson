using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace HemtentaTdd2017.blog
{
    public class Blog : IBlog
    {
        User _user;
        private IAuthenticator _auth;

        public bool UserIsLoggedIn => _user != null;
        public bool UserIsValid(User user) => user.RoleValue <= 2;

        public Blog(IAuthenticator auth)
        {
            _auth = auth;
        }

        public bool PublishPage(Page p)
        {
            if (string.IsNullOrWhiteSpace(p.Content) || string.IsNullOrWhiteSpace(p.Title))
                throw new BlogExceptions.InvalidPageException();
            if (!UserIsLoggedIn) throw new BlogExceptions.UserNotLoggedInException();
            if (UserIsValid(p.Author))
            {
                return true;
            }
            throw new BlogExceptions.CustomBlogException(
                string.Format("\n\nUser: {0}\nRole: {1}\nRoleValue: {2}\nValid: {3}", 
                p.Author.Name, p.Author.UserRole, p.Author.RoleValue, UserIsValid(p.Author)));
        }

        public void LoginUser(User user)
        {
            // user object seems ok.. -> check for user.NAME in db
            if (user != null)
            {
                /* hold in tmp-obj to look for existing object/*/
                var tmpUser = _auth.GetUserFromDatabase(user.Name);

                // user exists, compare tmp-object with user-object
                if (tmpUser.Password == user.Password)
                {
                     _user = tmpUser;
                }
            }
            else
            {
                throw new BlogExceptions.UserIsNullException();
            }
        }

        public void LogoutUser(User user)
        {
            if (user != null)
            {
                _user = null;
            }
            else if (_user == null)
            {
                throw new BlogExceptions.UserNotLoggedInException();
            }
            else
            {
                throw new BlogExceptions.UserIsNullException();
            }
        }

        public int SendEmail(string address, string caption, string body)
        {
            // prevent users from sending with empty body?
            // to_do: save to outbox if not logged in..
            if (string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(caption) ||
                string.IsNullOrWhiteSpace(body)) return 0;

            if (UserIsLoggedIn)
            {
                return 1;
            }
            return 0;
        }

    }
}

// to_do:  ChangeUserPassword(User user, old string, new string)

//to_do: user is added automatically to db on new user-object
//(not manually typed into(auth.(_userList) as it is atm)
//first time user tries to logon? not in db? add to db? pending?*/


//public void AddToDatabase(User newuser)
//{
//    Authenticator auth = new Authenticator();
//    auth.PendingUsers.Add(newuser);
//    auth.UpdateDatabse();
//}