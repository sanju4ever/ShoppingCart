using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout.Model
{
    public class ConstantPriceProduct : IProduct
    {
        public decimal Price { get; set; }

        public decimal CalculatePrice(int quantity)
        {
            return Price * quantity;
        }
    }
}
