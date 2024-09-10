namespace Prototype
{
    public interface IShoeType
    {
        string Name { get; set; }
        IShoeType Clone();
    }
}