using System;
namespace TransportationSystem
{
    // 1. Interface declaration
    interface ITransport
    {
        void Start();
        void Stop();
    }

    // 2. Bus class implementing ITransport
    class Bus : ITransport
    {
        public void Start()
        {
            Console.WriteLine("Bus is starting");
        }

        public void Stop()
        {
            Console.WriteLine("Bus is stopping");
        }
    }

    // 2. Train class implementing ITransport
    class Train : ITransport
    {
        public void Start()
        {
            Console.WriteLine("Train is starting");
        }

        public void Stop()
        {
            Console.WriteLine("Train is stopping");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 3. Creating objects using ITransport reference
            ITransport bus = new Bus();
            ITransport train = new Train();

            // Calling methods for Bus
            bus.Start();
            bus.Stop();

            // Calling methods for Train
            train.Start();
            train.Stop();

            // Keep console open
            Console.Read();
        }
    }
}