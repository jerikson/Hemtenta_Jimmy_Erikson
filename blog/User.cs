using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HemtentaTdd2017.blog
{
    public class User : UserRole
    {
        public string JpegAvatar { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Roles UserRole { get; set; } 
        public int RoleValue { get; set; }

        // New users are guests (3) request to "elevate" (descend..)
        public User(string name, Roles role):base(Roles.Visitor)
        {
            Name = name;
            Password = "password";
            Email = name + "@blog.com";
            UserRole = role;
            RoleValue = (int) UserRole;
        }

        // to_do: password random generator
        //
    }
}
