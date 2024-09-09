namespace Prototype
{
    public class SportsTypeShoe : ShoeBase
    {
        public SportsTypeShoe(IShoeType shoe) : base(shoe)
        {
        }

        public override IShoeType Clone()
        {
            return new SportsTypeShoe(this);
        }

    }
}