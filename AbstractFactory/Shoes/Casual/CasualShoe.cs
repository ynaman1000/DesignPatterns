namespace AbstractFactory.Shoes.Casual
{
    public class CasualShoe : Shoe
    {
        public override void CreateInventoryManagementPlan()
        {
            InventoryManagementPlan = new CasualIM();
        }

        public override void CreateDiscountingStrategy()
        {
            DiscountStrategy = new CasualDS();
        }
    }
}