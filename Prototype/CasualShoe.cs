namespace Prototype
{
    public class CasualShoe : ShoeBase
    {
        public CasualShoe(IShoeType shoe) : base(shoe)
        {
        }
        public CasualShoe(CasualShoe shoe) : base(shoe)
        {
        }

        public override IShoeType Clone()
        {
            return (IShoeType)MemberwiseClone();
        }
    }
}