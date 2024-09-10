namespace Prototype
{
    public class SportsTypeShoe : ShoeBase
    {
        private string _brandName;
        private string _sportName;
        public SportsTypeShoe(string brandName, string sportName) : base()
        {
            _brandName = brandName;
            _sportName = sportName;
        }
        public SportsTypeShoe(string brandName, string sportName, IShoeType shoe) : base(shoe)
        {
            _brandName = brandName;
            _sportName = sportName;
        }
        public SportsTypeShoe(SportsTypeShoe sportShoe) : base(sportShoe)
        {
            _brandName = sportShoe._brandName;
            _sportName = sportShoe._sportName;
        }

        public override IShoeType Clone()
        {
            return new SportsTypeShoe(this);
        }

    }
}