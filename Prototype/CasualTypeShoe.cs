namespace Prototype
{
    public class CasualTypeShoe : ShoeBase
    {
        public CasualTypeShoe(IShoeType shoe) : base(shoe)
        {
        }

        public override IShoeType Clone()
        {
            return new CasualTypeShoe(this);
        }

    }
}