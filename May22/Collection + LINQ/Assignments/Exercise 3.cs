using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductFilterExample
{
    // Step 1: Create a Product class
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Step 2: Create a list of 5 products
            List<Product> products = new List<Product>
            {
                new Product("Laptop", 1200),
                new Product("Mouse", 250),
                new Product("Keyboard", 600),
                new Product("Monitor", 800),
                new Product("USB Drive", 150)
            };

            // Step 3: Use LINQ to filter products with Price > 500
            var filteredProducts = from p in products
                                   where p.Price > 500
                                   select p;

            // Step 4: Display the filtered list
            Console.WriteLine("Products with price greater than 500:");
            foreach (var product in filteredProducts)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
            }
        }
    }
}
