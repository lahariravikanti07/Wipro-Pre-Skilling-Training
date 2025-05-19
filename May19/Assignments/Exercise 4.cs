using System;

namespace PaymentProcessing
{
    // 1. Abstract class with abstract and concrete methods
    abstract class PaymentMethod
    {
        public abstract void ProcessPayment(decimal amount);

        public void ShowPaymentMethod()
        {
            Console.WriteLine($"Payment Method: {this.GetType().Name}");
        }
    }

    // 2. Derived class for credit card payment
    class CreditCardPayment : PaymentMethod
    {
        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of Rs{amount}");
        }
    }

    // 2. Derived class for UPI payment
    class UPIPayment : PaymentMethod
    {
        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing UPI payment of Rs{amount}");
        }
    }

    // 3. Main method to demonstrate polymorphism
    class Program
    {
        static void Main(string[] args)
        {
            // Base class references pointing to derived class objects
            PaymentMethod payment1 = new CreditCardPayment();
            PaymentMethod payment2 = new UPIPayment();

            // Polymorphic behavior
            payment1.ShowPaymentMethod();
            payment1.ProcessPayment(2500.00m);

            Console.WriteLine();

            payment2.ShowPaymentMethod();
            payment2.ProcessPayment(1200.00m);
        }
    }
}
