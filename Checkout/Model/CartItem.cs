using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout.Model
{
    public class CartItem
    {
        public int Quantity { get; set; }

        public IProduct Product;

        public CartItem(IProduct product)
        {
            this.Product = product;
        }

        public decimal CalculateItemPrice()
        {
            return Product.CalculatePrice(Quantity);
        }
    }
}
