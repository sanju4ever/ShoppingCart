using System;

namespace Checkout.Model
{
    public class DifferentPriceProduct : IProduct
    {
        public decimal Price { get; set; }

        public decimal DiscountedPrice { get; set; }

        public decimal CalculatePrice(int quantity)
        {
            if (quantity >= 3)
            {
                var sQty = Math.DivRem(quantity, 3, out int rem);
                return DiscountedPrice * sQty * 3 + Price * rem;
            }

            return Price * quantity;
        }
    }
}
