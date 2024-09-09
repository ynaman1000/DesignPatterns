using AbstractFactory.Interfaces;

namespace AbstractFactory.Shoes.Casual.Nike
{
    public class NikeCasualDS : IDiscountStrategy
    {
        public int GetDiscount()
        {
            return 25;
        }
    }
}