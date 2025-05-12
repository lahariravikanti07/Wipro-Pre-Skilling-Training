using System;

// Abstract class
abstract class Notification
{
    // Abstract method
    public abstract void Send();

    // Concrete method
    public void ShowType()
    {
        Console.WriteLine("Sending Notification");
    }
}

// Derived class for Email Notification
class EmailNotification : Notification
{
    public override void Send()
    {
        Console.WriteLine("Sending Email Notification");

    }
}

// Derived class for SMS Notification
class SMSnotification : Notification
{
    public override void Send()
    {
        Console.WriteLine("Sending SMS Notification");
    }
}

// Main class
class Program
{
    static void Main(string[] args)
    {
        // Notification reference to EmailNotification object
        Notification email = new EmailNotification();
        email.ShowType();
        email.Send();

        Console.WriteLine();  // Separator for output

        // Notification reference to SMSNotification object
        Notification sms = new SMSnotification();
        sms.ShowType();
        sms.Send();
    }
}