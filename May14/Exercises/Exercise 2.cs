using System;

namespace BankingOperations
{
    // 1. Interface Definition
    interface IbankAccount
    {
        void Deposit(double amount);
        void Withdraw(double amount);
        void CheckBalance();
    }

    // 2. SavingsAccount Implementation
    class SavingsAccount : IbankAccount
    {
        private double balance = 0;

        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"[Savings] Deposited: {amount}. New Balance: {balance}");
        }

        public void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"[Savings] Withdrawn: {amount}. Remaining Balance: {balance}");
            }
            else
            {
                Console.WriteLine("[Savings] Insufficient balance.");
            }
        }

        public void CheckBalance()
        {
            Console.WriteLine($"[Savings] Current Balance: {balance}");
        }
    }

    // 2. CurrentAccount Implementation
    class CurrentAccount : IbankAccount
    {
        private double balance = 0;

        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"[Current] Deposited: {amount}. New Balance: {balance}");
        }

        public void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"[Current] Withdrawn: {amount}. Remaining Balance: {balance}");
            }
            else
            {
                Console.WriteLine("[Current] Insufficient balance.");
            }
        }

        public void CheckBalance()
        {
            Console.WriteLine($"[Current] Current Balance: {balance}");
        }
    }

    // 3. Main Method
    class Program
    {
        static void Main(string[] args)
        {
            IbankAccount savings = new SavingsAccount();
            IbankAccount current = new CurrentAccount();

            Console.WriteLine("=== Savings Account Transactions ===");
            savings.Deposit(500);
            savings.Withdraw(200);
            savings.CheckBalance();

            Console.WriteLine("\n=== current account Transactions ===");
            current.Deposit(1000);
            current.Withdraw(300);
            current.CheckBalance();

            Console.ReadLine();
        }
    }
}