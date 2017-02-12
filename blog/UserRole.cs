using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HemtentaTdd2017.blog
{
    public enum Roles
    {
        Op = 0,
        Administrator = 1,
        Publisher = 2,
        Guest = 3,
        Visitor = 4,
    }

    public class UserRole
    {
        private Roles _roleName;
        private int _roleValue;

        public UserRole(Roles role)
        {
            this._roleName = role;
            this._roleValue = (int) role;
        }

        public override string ToString() => _roleName.ToString();
    }
}
