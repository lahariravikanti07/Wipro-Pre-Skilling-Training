using System;
using System.Collections.Generic;

// Interface
interface IRentable
{
    void Rent();
}

// Base class
abstract class Vehicle : IRentable
{
    public string Make { get; set; }
    public string Model { get; set; }
    public double RentPerDay { get; set; }

    public Vehicle(string make, string model, double rentPerDay)
    {
        Make = make;
        Model = model;
        RentPerDay = rentPerDay;
    }

    public abstract void Rent();

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"{Make} {Model} - Rent Per Day: ${RentPerDay}");
    }
}

// Subclass: Car
class Car : Vehicle
{
    public Car(string make, string model, double rentPerDay)
        : base(make, model, rentPerDay) { }

    public override void Rent()
    {
        Console.WriteLine($"You have rented a Car: {Make} {Model} at ${RentPerDay} per day.");
    }
}

// Subclass: Bike
class Bike : Vehicle
{
    public Bike(string make, string model, double rentPerDay)
        : base(make, model, rentPerDay) { }

    public override void Rent()
    {
        Console.WriteLine($"You have rented a Bike: {Make} {Model} at ${RentPerDay} per day.");
    }
}

// Subclass: Truck
class Truck : Vehicle
{
    public Truck(string make, string model, double rentPerDay)
        : base(make, model, rentPerDay) { }

    public override void Rent()
    {
        Console.WriteLine($"You have rented a Truck: {Make} {Model} at ${RentPerDay} per day.");
    }
}

// Main Program
class Program
{
    static void Main()
    {
        List<Vehicle> availableVehicles = new List<Vehicle>
        {
            new Car("Toyota", "Camry", 50),
            new Bike("Yamaha", "FZ", 20),
            new Truck("Volvo", "FH", 100)
        };

        Console.WriteLine("Available Vehicles for Rent:");
        for (int i = 0; i < availableVehicles.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            availableVehicles[i].DisplayInfo();
        }

        List<Vehicle> rentedVehicles = new List<Vehicle>();
        string choice;

        do
        {
            Console.Write("\nEnter the number of the vehicle to rent (1-3): ");
            if (int.TryParse(Console.ReadLine(), out int selectedIndex) &&
                selectedIndex >= 1 && selectedIndex <= availableVehicles.Count)
            {
                Vehicle selectedVehicle = availableVehicles[selectedIndex - 1];
                selectedVehicle.Rent();
                rentedVehicles.Add(selectedVehicle);
            }
            else
            {
                Console.WriteLine("Invalid selection. Try again.");
            }

            Console.Write("Do you want to rent another vehicle? (yes/no): ");
            choice = Console.ReadLine().ToLower();

        } while (choice == "yes");

        Console.WriteLine("\nSummary of Rented Vehicles:");
        foreach (var vehicle in rentedVehicles)
        {
            vehicle.DisplayInfo();
        }

        Console.WriteLine("Thank you for using the Vehicle Rental System!");
    }
}
