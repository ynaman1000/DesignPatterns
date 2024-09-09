using AbstractFactory.Interfaces;

namespace AbstractFactory.Shoes.Casual
{
    public class CasualDS : IDiscountStrategy
    {
        public int GetDiscount()
        {
            return 10;
        }
    }
}