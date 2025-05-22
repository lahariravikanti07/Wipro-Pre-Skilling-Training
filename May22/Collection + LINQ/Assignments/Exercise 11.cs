using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductSorting
{
    // Step 1: Define the Product class
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Step 2: Create and add products to the list
            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 850.99 },
                new Product { Id = 2, Name = "Smartphone", Price = 499.99 },
                new Product { Id = 3, Name = "Headphones", Price = 89.99 },
                new Product { Id = 4, Name = "Monitor", Price = 199.99 },
                new Product { Id = 5, Name = "Keyboard", Price = 49.99 },
                new Product { Id = 6, Name = "Mouse", Price = 29.99 }
            };

            // Step 3: Sort products by price in descending order using LINQ
            var sortedProducts = products.OrderByDescending(p => p.Price);

            // Step 4: Print the sorted list
            Console.WriteLine("Products sorted by price (descending):");
            foreach (var product in sortedProducts)
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: ${product.Price:F2}");
            }
        }
    }
}

