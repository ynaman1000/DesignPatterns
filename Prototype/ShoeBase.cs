namespace Prototype
{
    public class ShoeBase : IShoeType
    {
        public string Name { get; set; }
        public ShoeBase() { }
        public ShoeBase(IShoeType shoe)
        {
            Name = shoe.Name;
        }

        public virtual IShoeType Clone()
        {
            return new ShoeBase(this);
        }

    }
}