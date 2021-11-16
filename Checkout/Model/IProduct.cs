
namespace Checkout.Model
{
    public interface IProduct
    {
        decimal CalculatePrice(int quantity);
    }
}
