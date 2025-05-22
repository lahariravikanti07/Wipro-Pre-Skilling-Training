using System;
using System.Collections.Generic;

// Product class
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(int id, string name, decimal price)
    {
        Id = id;
        Name = name;
        Price = price;
    }
}

// CartItem class
public class CartItem
{
    public Product Product { get; set; }
    public int Quantity { get; set; }

    public CartItem(Product product, int quantity)
    {
        Product = product;
        Quantity = quantity;
    }

    public decimal GetTotalPrice()
    {
        return Product.Price * Quantity;
    }
}

// ShoppingCart class
public class ShoppingCart
{
    private List<CartItem> items = new List<CartItem>();

    public void AddItem(Product product, int quantity)
    {
        // Check if product already exists in cart
        var existingItem = items.Find(i => i.Product.Id == product.Id);
        if (existingItem != null)
        {
            existingItem.Quantity += quantity;
        }
        else
        {
            items.Add(new CartItem(product, quantity));
        }
    }

    public void RemoveItem(int productId)
    {
        items.RemoveAll(i => i.Product.Id == productId);
    }

    public decimal GetCartTotal()
    {
        decimal total = 0;
        foreach (var item in items)
        {
            total += item.GetTotalPrice();
        }
        return total;
    }

    public void PrintCartDetails()
    {
        Console.WriteLine("Cart Items:");
        foreach (var item in items)
        {
            Console.WriteLine($"{item.Product.Name} x {item.Quantity} = {item.GetTotalPrice():0.00}");
        }
    }
}

// Main Program
public class Program
{
    public static void Main()
    {
        Product p1 = new Product(1, "Laptop", 2000.00m);
        Product p2 = new Product(2, "Mouse", 200.00m);
        Product p3 = new Product(3, "Keyboard", 450.00m);

        ShoppingCart cart = new ShoppingCart();
        cart.AddItem(p1, 1);
        cart.AddItem(p2, 2);
        cart.AddItem(p3, 1);

        cart.PrintCartDetails();
        Console.WriteLine($"Total Cart Value: {cart.GetCartTotal():0.00}");
    }
}
