namespace AbstractFactory.Interfaces
{
    public interface IShoe
    {
        public IInventoryManagement InventoryManagementPlan { get; set; }
        public IDiscountStrategy DiscountStrategy { get; set; }

        // big complex method that will change significantly based on the shoe type
        public void CreateInventoryManagementPlan();

        // big complex method that will change significantly based on the shoe type
        public void CreateDiscountingStrategy();
    }
}