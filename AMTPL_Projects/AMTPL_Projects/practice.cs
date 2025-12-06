using System;
using System.Collections.Generic;

public class Product
{
    public string Name { get; set; }
    public string Category { get; set; }
    public decimal Price { get; set; }
}

public class Program33
{
    public static void Main(string[] args)
    {
        List<Product> items = new List<Product>()
        {
            new Product(){ Name = "Phone", Category = "Electronics", Price = 15000 },
            new Product(){ Name = "Headphones", Category = "Electronics", Price = 1500 },
            new Product(){ Name = "Charger", Category = "Electronics", Price = 700 },
            new Product(){ Name = "Apple", Category = "Fruit", Price = 60 },
            new Product(){ Name = "Mango", Category = "Fruit", Price = 45 },
            new Product(){ Name = "Carrot", Category = "Vegetable", Price = 20 }
        };

        Dictionary<string, List<Product>> groups = new Dictionary<string, List<Product>>();

        foreach (var p in items)
        {
            if (!groups.ContainsKey(p.Category))
            {
                groups[p.Category] = new List<Product>();
            }

            groups[p.Category].Add(p);
        }
    }
}
