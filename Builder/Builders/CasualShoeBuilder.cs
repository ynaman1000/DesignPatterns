using Builder.Models;

namespace Builder.Builders
{
    public class CasualShoeBuilder : ShoeBuilder
    {
        public override void CreateSole()
        {
            _shoe.Sole = new ShoeSole("Standard Rubber", 2, 2, "Uniform");
        }
    }
}