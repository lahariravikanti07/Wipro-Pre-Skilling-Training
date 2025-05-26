using System;
using System.Collections.Generic;
using System.Linq;

namespace InventorySystem
{
    class Item
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Type: {Type}, Stock: {Stock}, Price: ${Price}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Create and populate the list
            List<Item> items = new List<Item>
            {
                new Item { Name = "Laptop", Type = "Electronics", Stock = 3, Price = 1200 },
                new Item { Name = "Mouse", Type = "Electronics", Stock = 25, Price = 20 },
                new Item { Name = "Keyboard", Type = "Electronics", Stock = 12, Price = 35 },
                new Item { Name = "Chair", Type = "Furniture", Stock = 2, Price = 150 },
                new Item { Name = "Desk", Type = "Furniture", Stock = 5, Price = 250 },
                new Item { Name = "Notebook", Type = "Stationery", Stock = 30, Price = 2 },
                new Item { Name = "Pen", Type = "Stationery", Stock = 50, Price = 1 },
                new Item { Name = "Monitor", Type = "Electronics", Stock = 6, Price = 300 },
                new Item { Name = "Shelf", Type = "Furniture", Stock = 1, Price = 200 },
                new Item { Name = "Lamp", Type = "Furniture", Stock = 8, Price = 60 },
                new Item { Name = "Printer", Type = "Electronics", Stock = 4, Price = 180 },
                new Item { Name = "Paper", Type = "Stationery", Stock = 40, Price = 0.5m },
                new Item { Name = "Ruler", Type = "Stationery", Stock = 15, Price = 1.5m },
                new Item { Name = "Whiteboard", Type = "Furniture", Stock = 3, Price = 300 },
                new Item { Name = "Tablet", Type = "Electronics", Stock = 7, Price = 450 }
            };

            // Step 2: Filter low stock items (stock < 5)
            var lowStockItems = items.Where(i => i.Stock < 5);
            Console.WriteLine("Low Stock Items (Stock < 5):");
            foreach (var item in lowStockItems)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n--------------------------------------\n");

            // Step 3: Group by Type
            var groupedByType = items.GroupBy(i => i.Type);

            Console.WriteLine("Items Grouped by Type:");
            foreach (var group in groupedByType)
            {
                Console.WriteLine($"\nType: {group.Key}");
                foreach (var item in group)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine("\n--------------------------------------\n");

            // Step 4: Highest priced item in each group
            Console.WriteLine("Highest Priced Item in Each Type Group:");
            var highestPricedInGroup = groupedByType
                .Select(g => g.OrderByDescending(i => i.Price).First());

            foreach (var item in highestPricedInGroup)
            {
                Console.WriteLine(item);
            }
        }
    }
}
