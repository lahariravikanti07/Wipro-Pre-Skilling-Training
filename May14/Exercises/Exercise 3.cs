using System;

// 1. Abstract Class
abstract class TicketBooking
{
    // Abstract Method
    public abstract void BookTicket(int seats);

    // Concrete method
    public void ShowBookingInfo()
    {
        Console.WriteLine("Booking tickets");
    }
}

// 2a. Derived Class - BusBooking
class BusBooking : TicketBooking
{
    public override void BookTicket(int seats)
    {
        Console.WriteLine($"Booking {seats} bus ticket(s)");
    }
}

// 2b. Derived Class - F;ightBooking
class FlightBooking : TicketBooking
{
    public override void BookTicket(int seats)
    {
        Console.WriteLine($"Booking {seats} flight ticket(s)");
    }
}

// 3. Main Method
class Program
{
    static void Main(string[] args)
    {
        // Using TicketBooking reference for BusBooking
        TicketBooking busBooking = new BusBooking();
        busBooking.ShowBookingInfo();
        busBooking.BookTicket(2);

        Console.WriteLine();

        // Using TicketBooking reference for FlightBooking
        TicketBooking flightBooking = new FlightBooking();
        flightBooking.ShowBookingInfo();
        flightBooking.BookTicket(3);
    }
}