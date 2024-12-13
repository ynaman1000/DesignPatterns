namespace Prototype
{
    public class SportsShoe : ShoeBase
    {
        private string _brandName;
        private string _sportName;
        public SportsShoe(string brandName, string sportName) : base()
        {
            _brandName = brandName;
            _sportName = sportName;
        }
        public SportsShoe(string brandName, string sportName, IShoeType shoe) : base(shoe)
        {
            _brandName = brandName;
            _sportName = sportName;
        }
        public SportsShoe(SportsShoe sportShoe) : base(sportShoe)
        {
            _brandName = sportShoe._brandName;
            _sportName = sportShoe._sportName;
        }

        public override IShoeType Clone()
        {
            return (IShoeType)MemberwiseClone();
        }
    }
}