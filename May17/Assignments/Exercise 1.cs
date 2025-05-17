using System;

namespace VehicleMaintenance
{
    // Step 1: Create the IMaintenance interface
    interface IMaintenance
    {
        void Service();
        void Repair();
    }

    // Step 2: Implement the interface in CarMaintenance
    class CarMaintenance : IMaintenance
    {
        public void Service()
        {
            Console.WriteLine("Car is being serviced");
        }

        public void Repair()
        {
            Console.WriteLine("Car is being repaired");
        }
    }

    // Step 2: Implement the interface in BikeMaintenance
    class BikeMaintenance : IMaintenance
    {
        public void Service()
        {
            Console.WriteLine("Bike is being serviced");
        }

        public void Repair()
        {
            Console.WriteLine("Bike is being repaired");
        }
    }

    // Step 3: Use the interface in Main
    class Program
    {
        static void Main(string[] args)
        {
            // Create IMaintenance references
            IMaintenance car = new CarMaintenance();
            IMaintenance bike = new BikeMaintenance();

            // Call methods for Car
            car.Service();
            car.Repair();

            // Call methods for Bike
            bike.Service();
            bike.Repair();
        }
    }
}
