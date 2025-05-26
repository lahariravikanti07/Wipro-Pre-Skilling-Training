using System;
using System.Collections.Generic;

// 1. Interface
public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
}

// 2. Abstract Class
public abstract class PaymentGateway
{
    public string GatewayName { get; set; }

    public PaymentGateway(string name)
    {
        GatewayName = name;
    }

    public virtual bool Validate()
    {
        Console.WriteLine($"{GatewayName}: Validating payment gateway...");
        return true;
    }
}

// 3. Razorpay Implementation
public class Razorpay : PaymentGateway, IPaymentProcessor
{
    public Razorpay() : base("Razorpay") { }

    public void ProcessPayment(decimal amount)
    {
        if (Validate())
        {
            Console.WriteLine($"Processing ${amount} using Razorpay.");
        }
    }
}

// 4. PayPal Implementation
public class PayPal : PaymentGateway, IPaymentProcessor
{
    public PayPal() : base("PayPal") { }

    public void ProcessPayment(decimal amount)
    {
        if (Validate())
        {
            Console.WriteLine($"Processing ${amount} using PayPal.");
        }
    }
}

// 5. Stripe Implementation
public class Stripe : PaymentGateway, IPaymentProcessor
{
    public Stripe() : base("Stripe") { }

    public void ProcessPayment(decimal amount)
    {
        if (Validate())
        {
            Console.WriteLine($"Processing ${amount} using Stripe.");
        }
    }
}

// 6. Main Program - Polymorphic Processing
public class Program
{
    public static void Main(string[] args)
    {
        List<IPaymentProcessor> payments = new List<IPaymentProcessor>
        {
            new Razorpay(),
            new PayPal(),
            new Stripe()
        };

        decimal[] amounts = { 1000.50m, 200.75m, 350.00m };

        for (int i = 0; i < payments.Count; i++)
        {
            payments[i].ProcessPayment(amounts[i]);
            Console.WriteLine(); // Just to add a line space
        }
    }
}
