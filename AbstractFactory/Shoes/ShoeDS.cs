using AbstractFactory.Interfaces;

namespace AbstractFactory.Shoes
{
    public class ShoeDS : IDiscountStrategy
    {
        public int GetDiscount()
        {
            return 0;
        }
    }
}