using Builder.Interfaces;

namespace Builder
{
    public class Director
    {
        public IShoeBuilder _shoeBuilder { get; set; }

        public Director(IShoeBuilder shoeBuilder)
        {
            _shoeBuilder = shoeBuilder;
        }

        public void BuildNikeShoe()
        {
            _shoeBuilder.SetSize(6);
            _shoeBuilder.SetBrand("Nike");
            _shoeBuilder.SetColor("Black");
            _shoeBuilder.CreateSole();
        }
    }
}
