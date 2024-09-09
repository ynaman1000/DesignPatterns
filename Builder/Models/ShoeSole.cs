using Builder.Interfaces;

namespace Builder.Models
{
    public class ShoeSole : IShoeSole
    {
        protected string _material;
        protected int _thickness;
        protected int _hardness;
        protected string _border;

        public string Material { get => _material; }
        public int Thickness { get => _thickness; }
        public int Hardness { get => _hardness; }
        public string Border { get => _border; }

        public ShoeSole(string material, int thickness, int hardness, string border)
        {
            _material = material;
            _thickness = thickness;
            _hardness = hardness;
            _border = border;
        }
    }
}