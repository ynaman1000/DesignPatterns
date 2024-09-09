using AbstractFactory.Interfaces;

namespace AbstractFactory.Shoes.Sport
{
    public class SportDS : IDiscountStrategy
    {
        public int GetDiscount()
        {
            return 20;
        }
    }
}