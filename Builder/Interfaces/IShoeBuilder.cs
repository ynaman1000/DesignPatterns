namespace Builder.Interfaces
{
    public interface IShoeBuilder
    {
        public IShoe Shoe { get; }
        public void SetSize(int size);
        public void SetBrand(string brand);
        public void SetColor(string color);
        public void CreateSole();
    }
}