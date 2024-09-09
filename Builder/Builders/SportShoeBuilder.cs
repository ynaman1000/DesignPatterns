using Builder.Models;

namespace Builder.Builders
{
    public class SportShoeBuilder : ShoeBuilder
    {
        public override void CreateSole()
        {
            _shoe.Sole = new ShoeSole("Carbon fiber reinforced Soft Rubber", 1, 3, "Tapered");
        }
    }
}