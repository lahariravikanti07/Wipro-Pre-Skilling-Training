using System;
using System.Collections.Generic;

// Interface for printing
interface IPrintable
{
    void Print();
}

// Abstract class for Invoice
abstract class Invoice : IPrintable
{
    public List<Product> Products { get; set; } = new List<Product>();
    public double TaxRate { get; set; }
    public double DiscountRate { get; set; }

    public Invoice(double taxRate, double discountRate)
    {
        TaxRate = taxRate;
        DiscountRate = discountRate;
    }

    // Abstract method
    public abstract double CalculateTotal();

    // Interface implementation
    public virtual void Print()
    {
        Console.WriteLine("Invoice Details:");
        foreach (var product in Products)
        {
            Console.WriteLine($"{product.Name} - Quantity: {product.Quantity}, Price: {product.Price:C}");
        }

        Console.WriteLine($"Tax Rate: {TaxRate * 100}%");
        Console.WriteLine($"Discount Rate: {DiscountRate * 100}%");
        Console.WriteLine($"Total Amount: {CalculateTotal():C}");
        Console.WriteLine("-----------------------------------");
    }
}

// Product class
class Product
{
    public string Name { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }

    public Product(string name, int quantity, double price)
    {
        Name = name;
        Quantity = quantity;
        Price = price;
    }
}

// RetailInvoice subclass
class RetailInvoice : Invoice
{
    public RetailInvoice(double taxRate, double discountRate)
        : base(taxRate, discountRate) { }

    public override double CalculateTotal()
    {
        double subtotal = 0;
        foreach (var product in Products)
        {
            subtotal += product.Price * product.Quantity;
        }

        double tax = subtotal * TaxRate;
        double discount = subtotal * DiscountRate;
        return subtotal + tax - discount;
    }
}

// WholesaleInvoice subclass
class WholesaleInvoice : Invoice
{
    public WholesaleInvoice(double taxRate, double discountRate)
        : base(taxRate, discountRate) { }

    public override double CalculateTotal()
    {
        double subtotal = 0;
        foreach (var product in Products)
        {
            subtotal += product.Price * product.Quantity;
        }

        // Higher discount for wholesale
        double tax = subtotal * TaxRate;
        double discount = subtotal * (DiscountRate + 0.1); // Extra 10% discount
        return subtotal + tax - discount;
    }
}

// Program to test the invoices
class Program
{
    static void Main()
    {
        var retailInvoice = new RetailInvoice(0.08, 0.05); // 8% tax, 5% discount
        retailInvoice.Products.Add(new Product("Laptop", 1, 1000));
        retailInvoice.Products.Add(new Product("Mouse", 2, 25));

        var wholesaleInvoice = new WholesaleInvoice(0.05, 0.10); // 5% tax, 10% base discount
        wholesaleInvoice.Products.Add(new Product("Monitor", 10, 150));
        wholesaleInvoice.Products.Add(new Product("Keyboard", 5, 45));

        retailInvoice.Print();
        wholesaleInvoice.Print();
    }
}
