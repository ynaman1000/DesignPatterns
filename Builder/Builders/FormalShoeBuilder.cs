using Builder.Models;

namespace Builder.Builders
{
    public class FormalShoeBuilder : ShoeBuilder
    {
        public override void CreateSole()
        {
            _shoe.Sole = new ShoeSole("Hard Rubber", 2, 6, "Slim");
        }
    }
}