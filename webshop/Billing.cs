using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HemtentaTdd2017.blog;

namespace HemtentaTdd2017.webshop
{
    public class Billing : IBilling
    {
        private decimal _cartCost;
        private decimal _shippingCost;
        public decimal Balance { get; }
        public decimal TotalCost => _cartCost + _shippingCost;

        public void Pay(decimal amount)
        {
           // to_do: implement user holding the balance, region etc
            if (Balance >= amount){}
        }

        public decimal CalcOrder(ICart cart, IShipping shipping)
        {
            if (shipping.ShipsTo(cart.Region))
            {
                _cartCost = cart.TotalCost;
                _shippingCost = shipping.TotalCost;
                
                return TotalCost; // Pay(TotalCost);  
            }
            throw new BlogExceptions.CustomBlogException("ILLEGAL REGION: " + cart.Region);
            // return 0;
        }
    }
}
