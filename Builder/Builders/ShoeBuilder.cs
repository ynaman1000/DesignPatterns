using Builder.Interfaces;
using Builder.Models;

namespace Builder.Builders
{
    public class ShoeBuilder : IShoeBuilder
    {
        protected IShoe _shoe;
        public IShoe Shoe { get => _shoe; }
        public ShoeBuilder()
        {
            _shoe = new Shoe();
        }

        public virtual void SetSize(int size)
        {
            _shoe.Size = size;
        }

        public virtual void SetBrand(string brand)
        {
            _shoe.Brand = brand;
        }

        public virtual void SetColor(string color)
        {
            _shoe.Color = color;
        }

        public virtual void CreateSole()
        {
            _shoe.Sole = new ShoeSole("General Rubber", 3, 4, "Normal");
        }
    }
}