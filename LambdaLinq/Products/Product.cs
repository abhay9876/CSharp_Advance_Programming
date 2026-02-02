/*WAP TO use of LINQ to group a list of products by category and calculate the average price for each category. It covers 
concepts of grouping, aggregation, and projection using LINQ in C#.*/

namespace Products
{
    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
    }
}