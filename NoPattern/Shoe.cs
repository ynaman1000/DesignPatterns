namespace NoPattern
{
    public class Shoe
    {
        public string Category { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }

        public Shoe(string category, string brand, string type)
        {
            Category = category;
            Brand = brand;
            Type = type;
        }
        public void CreateInventoryManagementPlan()
        {
            if (Category.Equals("Casual"))
            {
                if (Brand.Equals("Nike"))
                {
                }
                else if (Brand.Equals("Adidas"))
                {

                }
                else if (Brand.Equals("Puma"))
                {

                }
                else
                {

                }
            }
            else if (Category.Equals("Formal"))
            {

            }
            else if (Category.Equals("Sport"))
            {

            }
            else
            {

            }
        }
    }
}