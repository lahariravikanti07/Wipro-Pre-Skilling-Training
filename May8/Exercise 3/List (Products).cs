using System;
using System.Collections.Generic;
using System.Linq;

// Define the Product class with ID, Name and Price
class Product
{
    public int ID;
    public string Name;
    public double Price;
}

class Program
{
    static void Main()
    {
        // Create a List<Product> where each product has ID, Name and Price
        var products = new List<Product>
        {
            new Product { ID = 1, Name = "Laptop", Price = 1200.50 },
            new Product { ID = 2, Name = "Phone", Price = 800.00 },
            new Product { ID = 3, Name = "Tablet", Price = 450.25 },
            new Product { ID = 4, Name = "Monitor", Price = 299.99 },
            new Product { ID = 5, Name = "Headphones", Price = 150.75 }
        };

        // Sort the products by price in descending order.
        var sorted = products.OrderByDescending(p => p.Price).ToList();

        Console.WriteLine("Products sorted by price (descending):");

        // Print the sorted list
        sorted.ForEach(p => Console.WriteLine($"{p.ID}: {p.Name} - {p.Price}"));

        // Print the product with the highest price.
        Console.WriteLine($"\nHighest priced product: {sorted[0].Name} - {sorted[0].Price}");
    }
}