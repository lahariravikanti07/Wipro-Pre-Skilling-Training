using System;

class Payment
{
    public decimal Amount;
    public string Currency;

    public virtual void ExecutePayment()
    {
        Console.WriteLine($"executing payment of {Amount} {Currency}");
    }

    // Overload: amount only
    public void ExecutePayment(decimal amt)
    {
        Console.WriteLine($"Executing payment of {amt} with default currency");
    }

    // Overload: amount and currency
    public void ExecutePayment(decimal amt, string curr)
    {
        Console.WriteLine($"Executing payment of {amt} {curr}");
    }
}

class CreditCardPayment : Payment
{
    public string CardNumber;

    public override void ExecutePayment()
    {
        Console.WriteLine($"Executing credit card payment of {Amount} {Currency} using card {CardNumber}");
    }
}

class PayPalPayment : Payment
{
    public string Email;

    public override void ExecutePayment()
    {
        Console.WriteLine($"Executing PayPal payment of {Amount} {Currency} from account {Email}");
    }
}

class Program{
    static void Main()
    {
        // Credit Card Payment Example
        CreditCardPayment credit = new CreditCardPayment();
        credit.Amount = 9000;
        credit.Currency = "INR";
        credit.CardNumber = "1234-5678-9012-3456";
        credit.ExecutePayment();

        // PayPal Payment Example
        PayPalPayment paypal = new PayPalPayment();
        paypal.Amount = 8000;
        paypal.Currency = "USD";
        paypal.Email = "user@example.com";
        paypal.ExecutePayment();

        Console.WriteLine();

        // Method Overloading
        Payment genericPayment = new Payment();
        genericPayment.ExecutePayment(6000);
        genericPayment.ExecutePayment(600, "EUR");
    }
}