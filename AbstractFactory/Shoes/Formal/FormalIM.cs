using AbstractFactory.Interfaces;

namespace AbstractFactory.Shoes.Formal
{
    public class FormalIM : IInventoryManagement
    {
        public int GetInventoryCycle()
        {
            return 20;
        }
    }
}