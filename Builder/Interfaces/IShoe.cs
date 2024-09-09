namespace Builder.Interfaces
{
    public interface IShoe
    {
        public string Brand { get; set; }
        public string Color { get; set; }
        public int Size { get; set; }
        public IShoeSole Sole { get; set; }
    }
}