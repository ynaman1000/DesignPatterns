using AbstractFactory.Interfaces;

namespace AbstractFactory.Shoes.Sport.Nike
{
    public class NikeSportDS : IDiscountStrategy
    {
        public int GetDiscount()
        {
            return 5;
        }
    }
}