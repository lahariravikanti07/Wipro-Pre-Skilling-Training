using System;
using System.Collections.Generic;

// 1. Abstract class Vehicle
public abstract class Vehicle
{
    public string VehicleNumber { get; set; }
    public string Brand { get; set; }
    public double RatePerDay { get; set; }

    public Vehicle(string vehicleNumber, string brand, double ratePerDay)
    {
        VehicleNumber = vehicleNumber;
        Brand = brand;
        RatePerDay = ratePerDay;
    }

    // Virtual method to be overridden
    public virtual double CalculateRent(int days)
    {
        return RatePerDay * days;
    }
}

// 2. Derived class Car
public class Car : Vehicle
{
    public Car(string vehicleNumber, string brand, double ratePerDay)
        : base(vehicleNumber, brand, ratePerDay)
    {
    }

    public override double CalculateRent(int days)
    {
        double surcharge = 50; // fixed car surcharge
        return base.CalculateRent(days) + surcharge;
    }
}

// Derived class Bike
public class Bike : Vehicle
{
    public Bike(string vehicleNumber, string brand, double ratePerDay)
        : base(vehicleNumber, brand, ratePerDay)
    {
    }

    public override double CalculateRent(int days)
    {
        double surcharge = 10; // fixed bike surcharge
        return base.CalculateRent(days) + surcharge;
    }
}

// Derived class Truck
public class Truck : Vehicle
{
    public Truck(string vehicleNumber, string brand, double ratePerDay)
        : base(vehicleNumber, brand, ratePerDay)
    {
    }

    public override double CalculateRent(int days)
    {
        double surcharge = 100; // fixed truck surcharge
        return base.CalculateRent(days) + surcharge;
    }
}

// 3. Main Program
class Program
{
    static void Main(string[] args)
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("C123", "Toyota", 100),
            new Bike("B456", "Yamaha", 50),
            new Truck("T789", "Volvo", 200)
        };

        int rentalDays = 5;

        foreach (var vehicle in vehicles)
        {
            Console.WriteLine($"Vehicle: {vehicle.GetType().Name}, " +
                              $"Number: {vehicle.VehicleNumber}, " +
                              $"Brand: {vehicle.Brand}, " +
                              $"Rent for {rentalDays} days: {vehicle.CalculateRent(rentalDays):0.00}");
        }
    }
}
