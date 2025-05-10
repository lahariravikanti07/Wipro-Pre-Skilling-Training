using System;

class Appliance
{
    public virtual void Operator()
    {
        Console.WriteLine("Operating appliance");
    }
}

class WashingMachine : Appliance
{
    public override void Operate()
    {
        Console.WriteLine("Washing clothes";)
    }
}

class Program
{
    static void Main()
    {
        Appliance.myAppliance = new Appliance();
        myAppliance.Operate();  // Calls base class method

        WashingMachine myWasher = new WashingMachine();
        myWasher.Operate();  // Calls overriden method

        Appliance refWasher = new WashingMachine();
        refWasher.Operate();  // Demonstrates polymorphism
    }
}