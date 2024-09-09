using Builder.Interfaces;

namespace Builder.Models
{
    public class Shoe : IShoe
    {
        private string _brand;
        private string _color;
        private int _size;
        private IShoeSole _sole;

        public string Brand { get => _brand; set => _brand = value; }
        public string Color { get => _color; set => _color = value; }
        public int Size { get => _size; set => _size = value; }
        public IShoeSole Sole { get => _sole; set => _sole = value; }

        public Shoe()
        {
            _brand = string.Empty;
            _color = string.Empty;
            _size = 0;
            _sole = new ShoeSole(string.Empty, 0, 0, string.Empty);
        }
    }
}