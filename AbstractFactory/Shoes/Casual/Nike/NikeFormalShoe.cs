using AbstractFactory.Shoes.Formal;

namespace AbstractFactory.Shoes.Casual.Nike
{
    public class NikeCasualShoe : FormalShoe
    {
        public override void CreateInventoryManagementPlan()
        {
            InventoryManagementPlan = new NikeCasualIM();
        }

        public override void CreateDiscountingStrategy()
        {
            DiscountStrategy = new NikeCasualDS();
        }
    }
}