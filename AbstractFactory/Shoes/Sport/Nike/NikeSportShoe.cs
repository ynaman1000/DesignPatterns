namespace AbstractFactory.Shoes.Sport.Nike
{
    public class NikeSportShoe : SportShoe
    {
        public override void CreateInventoryManagementPlan()
        {
            InventoryManagementPlan = new NikeSportIM();
            Console.WriteLine("Nike sports shoe inventory management");
        }

        public override void CreateDiscountingStrategy()
        {
            DiscountStrategy = new NikeSportDS();
            Console.WriteLine("Nike sports shoe discount strategy");
        }
    }
}