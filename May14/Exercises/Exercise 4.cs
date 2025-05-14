using System;

namespace FoodOrderingSystem
{
    // Step 1: Abstract class
    abstract class FoodOrder
    {
        // Abstract method
        public abstract void PlaceOrder(string item);

        // Concrete method
        public void Orderinfo()
        {
            Console.WriteLine("Placing food order");
        }
    }

    // Step 2: Derived class for FastFoodOrder
    class FastFoodOrder : FoodOrder
    {
        public override void PlaceOrder(string item)
        {
            Console.WriteLine($"Order placed for {item} at Fast Food Outlet");
        }
    }

    // Step 2: Derived class for FineDiningOrder
    class FineDiningOrder : FoodOrder
    {
        public override void PlaceOrder(string item)
        {
            Console.WriteLine($"Order placed for {item} at Fine Dining Restaurant");
        }
    }

    // Step 3: Main method
    class program
    {
        static void Main(string[] args)
        {
            // Using FoodOrder reference for FastFoodOrder
            FoodOrder fastFood = new FastFoodOrder();
            fastFood.Orderinfo();
            fastFood.PlaceOrder("Burger");

            Console.WriteLine();

            // Using FoodOrder reference for FineDiningOrder
            FoodOrder fineDining = new FineDiningOrder();
            fineDining.Orderinfo();
            fineDining.PlaceOrder("Steak");
        }
    }
}