using Checkout.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bean Can
            var beanCan = new ConstantPriceProduct();
            beanCan.Price = 0.65M;

            // Avacado
            var avacado = new DifferentPriceProduct();
            avacado.Price = 1.25M;
            avacado.DiscountedPrice = 1.00M;

            // Soda Can
            var sodaCan = new SpecialFreeProduct();
            sodaCan.Price = 2.05M;

            // Create Cart Item List
            var cartItems = new List<CartItem>();

            // Add Bean Cans
            var cartItem = new CartItem(beanCan);
            cartItem.Quantity = 2;
            cartItems.Add(cartItem);

            // Add Avacados
            cartItem = new CartItem(avacado);
            cartItem.Quantity = 5;
            cartItems.Add(cartItem);

            // Add Soda Cans
            cartItem = new CartItem(sodaCan);
            cartItem.Quantity = 4;
            cartItems.Add(cartItem);

            var totalPrice = 0.00M;
            foreach (var ci in cartItems)
            {
                totalPrice += ci.CalculateItemPrice();
            }

            Console.WriteLine("Total Price: $" + totalPrice);
            Console.ReadKey();
        }
    }
}
