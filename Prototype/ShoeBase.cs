namespace Prototype
{
    public class ShoeBase : IShoeType
    {
        public string Name { get; set; } = string.Empty;
        public ShoeBase() { }
        public ShoeBase(IShoeType shoe)
        {
            Name = shoe.Name;
        }

        public virtual IShoeType Clone()
        {
            return (IShoeType)MemberwiseClone();
        }

    }
}