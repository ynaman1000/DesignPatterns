namespace Prototype
{
    public class FormalShoe : ShoeBase
    {
        public FormalShoe(IShoeType shoe) : base(shoe)
        {
        }
        public FormalShoe(FormalShoe shoe) : base(shoe)
        {
        }

        public override IShoeType Clone()
        {
            return (IShoeType)MemberwiseClone();
        }
    }
}