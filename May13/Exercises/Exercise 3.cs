using System;

// Step 1: Abstract class definition
abstract class Paymentgateway
{
    // Abstract method
    public abstract void ProcessPayment(double amount);

    // Concrete method
    public void ShowGatewayName()
    {
        Console.WriteLine("Processing payment through gateway");
    }
}

// Step 2a: Derived class - StripeGateway
class StripeGateway : Paymentgateway
{
    public override void ProcessPayment(double amount)
    {
        Console.WriteLine($"Procesing payment through Stripe: Rs{amount}");
    }
}

// Step 2b: Derived class - PayPalGateway
class PaypalGateway : Paymentgateway
{
    public override void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing payment through PayPal: Rs{amount}");
        
    }
}

// Step 3: Main method to test the functionality
class Program
{
    static void Main(string[] args)
    {
        // Using PaymentGateway reference for Stripe
        Paymentgateway stripe = new StripeGateway();
        stripe.ShowGatewayName();
        stripe.ProcessPayment(1500.00);

        Console.WriteLine();

        //Using PaymentGateway reference for PayPal
        Paymentgateway paypal = new PaypalGateway();
        paypal.ShowGatewayName();
        paypal.ProcessPayment(2000.00);
    }
}