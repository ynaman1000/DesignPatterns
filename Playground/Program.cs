using Builder;
using Builder.Builders;
using Playground;
using Prototype;

var factoryMethodClient = new AbstractFactoryClient();
factoryMethodClient.CreateShoe("Sport", "Nike");
factoryMethodClient.Shoe.CreateInventoryManagementPlan();
factoryMethodClient.Shoe.CreateDiscountingStrategy();
var invntryCycle = factoryMethodClient.Shoe.InventoryManagementPlan.GetInventoryCycle();
var discount = factoryMethodClient.Shoe.DiscountStrategy.GetDiscount();
Console.WriteLine("");

var builder = new SportShoeBuilder();
var director = new Director(builder);
director.BuildNikeShoe();
var nikeShoe = builder.Shoe;
Console.WriteLine("");

var shoeTemplate = new ShoeBase();
shoeTemplate.Name = "base";
var shoes = new List<IShoeType> { new ShoeBase(shoeTemplate) };
shoeTemplate.Name = "casual";
shoes.Add(new CasualTypeShoe(shoeTemplate));
shoeTemplate.Name = "formal";
shoes.Add(new FormalTypeShoe(shoeTemplate));
shoeTemplate.Name = "sport";
shoes.Add(new SportsTypeShoe(shoeTemplate));
var shoesClone = new List<IShoeType>();
foreach (var shoe in shoes)
{
    shoesClone.Add(shoe.Clone());
}
shoesClone[0].Name = "baseClone";
Console.WriteLine("");
