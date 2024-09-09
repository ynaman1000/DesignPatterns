using AbstractFactory.Interfaces;

namespace AbstractFactory.Shoes.Sport.Adidas
{
    public class AdidasSportDS : IDiscountStrategy
    {
        public int GetDiscount()
        {
            return 25;
        }
    }
}