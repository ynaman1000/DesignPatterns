using AbstractFactory.Interfaces;

namespace AbstractFactory.Shoes
{
    public class ShoeIM : IInventoryManagement
    {
        public int GetInventoryCycle()
        {
            return 1;
        }
    }
}