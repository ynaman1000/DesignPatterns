namespace Prototype
{
    public class FormalTypeShoe : ShoeBase
    {
        public FormalTypeShoe(IShoeType shoe) : base(shoe)
        {
        }
        public FormalTypeShoe(FormalTypeShoe shoe) : base(shoe)
        {
        }

        public override IShoeType Clone()
        {
            return new FormalTypeShoe(this);
        }

    }
}