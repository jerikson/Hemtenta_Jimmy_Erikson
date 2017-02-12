using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemtentaTdd2017.webshop
{
    public class WebshopExceptions
    {}

    public class ShoppingCartException : Exception
    {
        public override string Message => ("\n\n''");
    }
}
