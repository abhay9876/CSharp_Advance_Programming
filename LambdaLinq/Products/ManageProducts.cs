namespace Products
{
    public class ManageProducts
    {
        public static void GroupProducts()
        {
            List<Product> products = new List<Product>
        {
            new Product { Name = "Laptop", Category = "Electronics", Price = 60000 },
            new Product { Name = "T-Shirt", Category = "Cloth", Price = 1500 },
            new Product { Name = "Pants", Category = "Cloth", Price = 2500 },
            new Product { Name = "Mobile", Category = "Electronics", Price = 30000 },
            new Product { Name = "Charger", Category = "Electronics", Price = 40000 }
        };

            var result = products.GroupBy(p => p.Category)
                         .Select(g => new
                         {
                             Category = g.Key,
                             AveragePrice = g.Average(p => p.Price)
                         });

            Console.WriteLine("Average Price by Category : ");

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Category} : {item.AveragePrice}");
            }
        }
    }
}