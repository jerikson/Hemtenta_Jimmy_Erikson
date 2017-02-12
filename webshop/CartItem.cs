using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HemtentaTdd2017.webshop
{

    //public bool Equals(CartItem other)
    //{
    //    return this.Id == other.Id &&
    //}

    public class CartItem //: IEquatable<CartItem>
    {
        private int _id;
        private string _name;
        private decimal _price;
        private Product _product;
        private int _amount;
        private string _category; //array const?


        public CartItem()
        {
        }

        public int Amount
        {
            get { return _amount;  }
            set { _amount = value;  }
        }
          

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }

        }
        public Product Product
        {
            get { return _product; }
            set { _product = value; }
        }
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

    }




}
