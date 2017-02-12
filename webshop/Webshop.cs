using System;

namespace HemtentaTdd2017.webshop
{
    public class Webshop : IWebshop
    {
        ICart _cart { get; }
        IShipping _shipping { get; }

        public void Checkout(IBilling billing)
        {
            if (billing != null)
            {
                billing.Pay(billing.CalcOrder(_cart, _shipping));
            }
            else
            {
                throw new NullReferenceException();
            }
           
        }

        // one cart per service?
        public Webshop(ICart cart)
        {
            _cart = cart;
        }

        public ICart Cart
        {
            get { return _cart; }
        }

        public IShipping Shipping
        {
            get { return _shipping; }
        }
    }
}