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
var shoes = new List<IShoeType> { shoeTemplate.Clone() };
var casualShoe = new CasualTypeShoe(shoeTemplate);
casualShoe.Name = "casual";
shoes.Add(casualShoe);
var formalShoe = new FormalTypeShoe(shoeTemplate);
formalShoe.Name = "formal";
shoes.Add(formalShoe);
var sportShoe = new SportsTypeShoe("adidas", "basketball", shoeTemplate);
sportShoe.Name = "sport";
shoes.Add(sportShoe);
var shoesClone = new List<IShoeType>();
foreach (var shoe in shoes)
    shoesClone.Add(shoe.Clone());
shoesClone[0].Name = "baseClone";
shoesClone[1].Name = "casualClone";
Console.WriteLine("");
