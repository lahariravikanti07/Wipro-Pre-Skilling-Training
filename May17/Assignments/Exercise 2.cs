using System;

// Step 1: Define the interface
public interface ISupportTicket
{
    void CreateTicket(string issue);
    void ResolveTicket(int ticketId);
}

// Step 2: Implement the interface in EmailSupport
public class EmailSupport : ISupportTicket
{
    public void CreateTicket(string issue)
    {
        Console.WriteLine($"Creating ticket via Email: {issue}");
    }

    public void ResolveTicket(int ticketId)
    {
        Console.WriteLine($"Resolving ticket {ticketId} via Email");
    }
}

// Step 2: Implement the interface in PhoneSupport
public class PhoneSupport : ISupportTicket
{
    public void CreateTicket(string issue)
    {
        Console.WriteLine($"Creating ticket via Phone: {issue}");
    }

    public void ResolveTicket(int ticketId)
    {
        Console.WriteLine($"Resolving ticket {ticketId} via Phone");
    }
}

// Step 3: Main method to test the implementation
public class Program
{
    public static void Main(string[] args)
    {
        ISupportTicket emailSupport = new EmailSupport();
        ISupportTicket phoneSupport = new PhoneSupport();

        // Test Email Support
        emailSupport.CreateTicket("Unable to send emails.");
        emailSupport.ResolveTicket(101);

        // Test Phone Support
        phoneSupport.CreateTicket("Internet connection not working.");
        phoneSupport.ResolveTicket(202);
    }
}
