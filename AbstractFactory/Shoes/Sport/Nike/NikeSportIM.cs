using AbstractFactory.Interfaces;

namespace AbstractFactory.Shoes.Sport.Nike
{
    public class NikeSportIM : IInventoryManagement
    {
        public int GetInventoryCycle()
        {
            return 200;
        }
    }
}