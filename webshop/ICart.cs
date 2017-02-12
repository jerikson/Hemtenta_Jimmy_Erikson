using System;
using System.Collections.Generic;

namespace HemtentaTdd2017.webshop
{
    public interface ICart
    {
        void AddProduct(Product p, int amount);
        void RemoveProduct(Product p, int amount);
        decimal TotalCost { get; }
        int ItemsInCart { get; }
        string Region { get; set; }
    }
}