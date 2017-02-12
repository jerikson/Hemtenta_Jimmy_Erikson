using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HemtentaTdd2017.blog
{
    public class BlogExceptions
    {

        public class UserNotLoggedInException : Exception { }
        public class UserIsNullException : Exception { }
        public class InvalidPageException : Exception { }
        public class IllegalUserException : Exception
        {
            public override string Message => ("\n\n'User role-value is illegal. Try elevating or descending user'");
        }

        public class CustomBlogException : Exception
        {
            public CustomBlogException(string message)
                : base(message) { }

        }
    }
}
