using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Xml;

namespace HemtentaTdd2017.webshop
{
    public class Cart : ICart
    {
        private const int ILLEGAL_VALUE = 99;
        private List<CartItem> _cartItems;
        private DateTime _dateCreated;
        private DateTime _dateLastUpdate;
        public string Region { get; set; }
        public int Id { get; set; }
        public int ItemsInCart { get { return _cartItems.Count; } }
        public decimal TotalCost{ get { return _cartItems.Sum(i => i.Price); } }
        

        public Cart()
        {
            if (_cartItems == null)
            {
                _cartItems = new List<CartItem>();
                _dateCreated = DateTime.Now;
            }
        }

        // Add product to cart
        public void AddProduct(Product product, int amount)
        {
            if (product == null || amount <= 0 || amount > ILLEGAL_VALUE) return;

            // Create item of product before adding
            var item = new CartItem()
            {
                Product = product,
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Amount = amount
            };
            _cartItems.AddRange(Enumerable.Repeat(item, amount));
            DateLastUpdate = DateTime.Now;
        }

        public void RemoveProduct(Product product, int amount)
        {
            if (product == null || amount <= 0) return;

            var remove= _cartItems.Find(x => x.Product == product);

            // how to do this in one line :D?
            for (var i = 0; i < amount; i ++)
            {
                _cartItems.Remove(remove);
            }

            DateLastUpdate = DateTime.Now;
        }
       
        // to_do:
        public void UpdateCart(Product p, int amount)
        {
            _dateLastUpdate = DateTime.Now;
        }

        public DateTime DateCreated
        {
            get { return _dateCreated; }
            set { _dateCreated = value; }
        }

        public DateTime DateLastUpdate
        {
            get { return _dateLastUpdate; }
            set { _dateLastUpdate = value; }
        }

        public List<CartItem> CartItems
        {
            get { return _cartItems; }
            set { _cartItems = value; }
        }

    }
}