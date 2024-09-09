using AbstractFactory.Interfaces;

namespace AbstractFactory.Shoes.Formal
{
    public class FormalDS : IDiscountStrategy
    {
        public int GetDiscount()
        {
            return 10;
        }
    }
}