namespace AbstractFactory.Shoes.Sport
{
    public class SportShoe : Shoe
    {
        public override void CreateInventoryManagementPlan()
        {
            InventoryManagementPlan = new SportIM();
        }

        public override void CreateDiscountingStrategy()
        {
            DiscountStrategy = new SportDS();
        }
    }
}