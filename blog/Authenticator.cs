using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemtentaTdd2017.blog
{
    public class Authenticator : IAuthenticator
    {
        // Mock db
        private List<User> _database = new List<User>
        {
            new User("John", Roles.Op),
            new User("Admin",Roles.Administrator),
            new User("Peter", Roles.Publisher),
            new User("Jane",Roles.Visitor),
            new User("Goeran",Roles.Guest)
        };

        public User GetUserFromDatabase(string username)
        {
            return _database.FirstOrDefault(u => u.Name == username);
        }
    }
}
