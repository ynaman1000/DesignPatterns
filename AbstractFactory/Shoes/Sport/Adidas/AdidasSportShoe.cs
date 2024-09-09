namespace AbstractFactory.Shoes.Sport.Adidas
{
    public class AdidasSportShoe : SportShoe
    {
        public override void CreateDiscountingStrategy()
        {
            DiscountStrategy = new AdidasSportDS();
        }
    }
}