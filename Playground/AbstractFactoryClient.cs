using AbstractFactory.Interfaces;
using AbstractFactory.Shoes;
using AbstractFactory.Shoes.Sport;
using AbstractFactory.Shoes.Sport.Adidas;
using AbstractFactory.Shoes.Sport.Nike;

namespace Playground
{
    public class AbstractFactoryClient
    {
        public IShoe Shoe { get; set; }

        public void CreateShoe(string type, string brand)
        {
            if (type.Equals("Sport"))
                CreateSportShoe(brand);
            else
                Shoe = new Shoe();
        }

        private void CreateSportShoe(string brand)
        {
            if (brand.Equals("Nike"))
                Shoe = new NikeSportShoe();
            else if (brand.Equals("Adidas"))
                Shoe = new AdidasSportShoe();
            else
                Shoe = new SportShoe();
        }
    }
}