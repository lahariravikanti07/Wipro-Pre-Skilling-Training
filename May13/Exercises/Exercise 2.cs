using System;

namespace RestaurantOrderManagement
{
    // 1. create Interface IOrder
    interface IOrder
    {
        void PlaceOrder(string item);
        void CancelOrder(string item);
    }

    // 2. Implement IOrder in DineInOrder
    class DineInOrder : IOrder
    {
        public void PlaceOrder(string item)
        {
            Console.WriteLine($"Placing dine-in order for {item}");
        }

        public void CancelOrder(string item)
        {
            Console.WriteLine($"Cancelling dine-in order for {item}");
        }
    }

    // 2. Implement Iorder in TakeawayOrder
    class TakeawayOrder : IOrder
    {
        public void PlaceOrder(string item)
        {
            Console.WriteLine($"Placing takeaway order for {item}");
        }

        public void CancelOrder(string item)
        {
            Console.WriteLine($"Cancelling takeaway order for {item}");
        }
    }

    // 3. Main method
    class Program
    {
        static void Main(string[] args)
            {
            IOrder dineIn = new DineInOrder();
            dineIn.PlaceOrder("Pasta");
            dineIn.CancelOrder("Pasta");

            Console.WriteLine();    // For spacing

            IOrder takeaway = new TakeawayOrder();
            takeaway.PlaceOrder("Burger");
            takeaway.CancelOrder("Burger");
        }
    }
}