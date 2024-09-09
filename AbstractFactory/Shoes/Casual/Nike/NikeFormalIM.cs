using AbstractFactory.Interfaces;

namespace AbstractFactory.Shoes.Casual.Nike
{
    public class NikeCasualIM : IInventoryManagement
    {
        public int GetInventoryCycle()
        {
            return 5;
        }
    }
}