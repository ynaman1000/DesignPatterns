namespace Prototype
{
    public interface IShoeType : IPrototype<IShoeType>
    {
        string Name { get; set; }
    }
}