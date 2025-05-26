using System;
using System.Collections.Generic;
using System.IO;

class Transaction
{
    public DateTime Time { get; set; }
    public string Type { get; set; } // "Deposit" or "Withdraw"
    public decimal Amount { get; set; }

    public Transaction(string type, decimal amount)
    {
        Time = DateTime.Now;
        Type = type;
        Amount = amount;
    }

    public override string ToString()
    {
        return $"{Time}|{Type}|{Amount}";
    }

    public static Transaction FromString(string line)
    {
        var parts = line.Split('|');
        return new Transaction(parts[1], decimal.Parse(parts[2]))
        {
            Time = DateTime.Parse(parts[0])
        };
    }
}

class BankAccount
{
    private List<Transaction> transactions;
    private const string fileName = "./transactions.txt"; // ✅ relative safe path

    public BankAccount()
    {
        transactions = new List<Transaction>();
        LoadTransactions();
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Amount must be positive.");
            return;
        }

        transactions.Add(new Transaction("Deposit", amount));
        Console.WriteLine($"Deposited: ${amount}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Amount must be positive.");
            return;
        }

        if (GetBalance() < amount)
        {
            Console.WriteLine("Insufficient funds.");
            return;
        }

        transactions.Add(new Transaction("Withdraw", amount));
        Console.WriteLine($"Withdrew: ${amount}");
    }

    public void ShowSummary()
    {
        Console.WriteLine("\n--- Transaction Summary ---");
        foreach (var t in transactions)
        {
            Console.WriteLine($"{t.Time}: {t.Type} ${t.Amount}");
        }
        Console.WriteLine($"Current Balance: ${GetBalance()}\n");
    }

    public decimal GetBalance()
    {
        decimal balance = 0;
        foreach (var t in transactions)
        {
            if (t.Type == "Deposit")
                balance += t.Amount;
            else if (t.Type == "Withdraw")
                balance -= t.Amount;
        }
        return balance;
    }

    public void SaveTransactions()
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var t in transactions)
                    writer.WriteLine(t.ToString());
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving transactions: {ex.Message}");
        }
    }

    private void LoadTransactions()
    {
        if (!File.Exists(fileName))
            return;

        try
        {
            var lines = File.ReadAllLines(fileName);
            foreach (var line in lines)
            {
                transactions.Add(Transaction.FromString(line));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading transactions: {ex.Message}");
        }
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();
        account.ShowSummary();

        while (true)
        {
            Console.WriteLine("Choose an option: 1) Deposit  2) Withdraw  3) Exit");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Write("Enter deposit amount: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
                        account.Deposit(depositAmount);
                    else
                        Console.WriteLine("Invalid amount.");
                    break;

                case "2":
                    Console.Write("Enter withdrawal amount: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount))
                        account.Withdraw(withdrawAmount);
                    else
                        Console.WriteLine("Invalid amount.");
                    break;

                case "3":
                    account.SaveTransactions();
                    Console.WriteLine("Transactions saved. Exiting...");
                    return;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}
