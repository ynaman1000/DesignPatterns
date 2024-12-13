using AbstractFactory.Interfaces;

namespace AbstractFactory.Shoes
{
    public class Shoe : IShoe
    {
        private IInventoryManagement _inventoryManagementPlan;
        public IInventoryManagement InventoryManagementPlan
        {
            get => _inventoryManagementPlan;
            set => _inventoryManagementPlan = value;
        }

        private IDiscountStrategy _discountStrategy;
        public IDiscountStrategy DiscountStrategy
        {
            get => _discountStrategy;
            set => _discountStrategy = value;
        }

        public virtual void CreateInventoryManagementPlan()
        {
            InventoryManagementPlan = new ShoeIM();
        }
        public virtual void CreateDiscountingStrategy()
        {
            DiscountStrategy = new ShoeDS();
        }
    }
}