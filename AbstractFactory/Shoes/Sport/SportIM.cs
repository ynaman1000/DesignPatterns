using AbstractFactory.Interfaces;

namespace AbstractFactory.Shoes.Sport
{
    public class SportIM : IInventoryManagement
    {
        public int GetInventoryCycle()
        {
            return 10;
        }
    }
}