/*
To put these concepts into practice, try the following exercise:

1. Create a list of products, each with a name, category, and price.
2. Use LINQ to:
    A. Filter products by a minimum price.
    B. Group products by category.
    C. Sort products within each category by price in descending order.
    D. Display the top 3 most expensive products in each category.
*/

using System;
using System.Collections.Generic;
using System.Linq;

public class Product
{
    public string? Name { get; set; }
    public string? Category { get; set; }
    public double Price { get; set; }

    public void Run()
    {
        List<Product> products = new List<Product>
        {
            new Product { Name = "Laptop", Category = "Electronics", Price = 1200 },
            new Product { Name = "Smartphone", Category = "Electronics", Price = 800 },
            new Product { Name = "Decoder", Category = "Electronics", Price = 600 },
            new Product { Name = "Fire Alarm", Category = "Electronics", Price = 700 },
            new Product { Name = "Sound System", Category = "Electronics", Price = 950 },
            new Product { Name = "Desk Chair", Category = "Furniture", Price = 150 },
            new Product { Name = "Dining Table", Category = "Furniture", Price = 500 },
            new Product { Name = "Stool", Category = "Furniture", Price = 100 },
            new Product { Name = "TV Stand", Category = "Furniture", Price = 200 },
            new Product { Name = "Reading Table", Category = "Furniture", Price = 250 },
            new Product { Name = "Washing Machine", Category = "Appliances", Price = 700 },
            new Product { Name = "Refrigerator", Category = "Appliances", Price = 1000 },
            new Product { Name = "Microwave", Category = "Appliances", Price = 800 },
            new Product { Name = "Blender", Category = "Appliances", Price = 200 },
            new Product { Name = "Toaster", Category = "Appliances", Price = 250 }
        };

        // A. Filter products by a minimum price.

        Console.WriteLine("Filter products by a minimum price:\n");
        double minPriceThreshold = 600;
        var minProduct = products.Where(x => x.Price >= minPriceThreshold);

        foreach (var product in minProduct)
        {
            Console.WriteLine($"Name: {product.Name} \nCategory: {product.Category} \nPrice: {product.Price}");
            Console.WriteLine("");
        }
        


        // B. Group products by category.

        Console.WriteLine("\n\nGroup products by category:\n");
        var groupByCategory = products.GroupBy(x => x.Category);
        foreach (var group in groupByCategory)
        {
            Console.WriteLine($"Category: {group.Key}");
            foreach (var product in group)
            {
                Console.WriteLine($"Name: {product.Name} \tPrice: {product.Price}");
            }
            Console.WriteLine("");
        }


        // C. Sort products within each category by price in descending order.

        Console.WriteLine("\n\nSort products within each category by price in descending order:\n");
        var sortGroupByCategory = products.OrderByDescending(x => x.Price)
            .GroupBy(x => x.Category);
        foreach (var group in sortGroupByCategory)
        {
            Console.WriteLine($"Category: {group.Key}");
            foreach (var product in group)
            {
                Console.WriteLine($"Name: {product.Name} \tPrice: {product.Price}");
            }
            Console.WriteLine("");
        }


        // D. Display the top 3 most expensive products in each category.

        Console.WriteLine("\n\nThe top 3 most expensive products in each category:\n");
        var topThree = products.OrderByDescending(x => x.Price)
                    .GroupBy(x => x.Category)
                    .Select(group => new
                        {
                            Category = group.Key,
                            TopThreeProducts = group.Take(3)
                        }
                    );
        foreach (var group in topThree)
        {
            Console.WriteLine($"Category: {group.Category}");
            
            foreach (var product in group.TopThreeProducts)
            {
                Console.WriteLine($"Name: {product.Name} \tPrice: {product.Price}");
            }
            Console.WriteLine("");
            
        }
    }
}
