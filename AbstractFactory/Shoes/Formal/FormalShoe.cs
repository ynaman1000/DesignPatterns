namespace AbstractFactory.Shoes.Formal
{
    public class FormalShoe : Shoe
    {
        public override void CreateInventoryManagementPlan()
        {
            InventoryManagementPlan = new FormalIM();
        }

        public override void CreateDiscountingStrategy()
        {
            DiscountStrategy = new FormalDS();
        }
    }
}