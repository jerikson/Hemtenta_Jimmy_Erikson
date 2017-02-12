using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemtentaTdd2017.webshop
{
    public interface IProduct
    {
         decimal Price { get; set; }
         string Name { get; set; }

    }
}
