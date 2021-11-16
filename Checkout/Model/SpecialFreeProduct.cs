using System;

namespace Checkout.Model
{
    public class SpecialFreeProduct : IProduct
    {
        public decimal Price { get; set; }        

        public decimal CalculatePrice(int quantity)
        {
            if (quantity >= 3)
            {
                var sQty = Math.DivRem(quantity, 3, out int rem);
                return Price * (sQty * 2 + rem);
            }

            return Price * quantity;
        }
    }
}