using AbstractFactory.Interfaces;

namespace AbstractFactory.Shoes.Casual
{
    public class CasualIM : IInventoryManagement
    {
        public int GetInventoryCycle()
        {
            return 2;
        }
    }
}