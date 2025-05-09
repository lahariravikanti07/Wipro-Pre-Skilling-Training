using System;


namespace ConsoleApp2{
    class Animal
    {
        public string Name;
        public string Species;

        public void DisplayName()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Species: {Species}");
        }
    }

    class Dog : Animal{
        public string Breed;

        public void DisplayDog()
        {
            Console.WriteLine($"Breed: {Breed}");
        }
    }
}
    class Program
    {
        static void Main()
        {
            Dog dog1 = new Dog();
            dog1.Name = "Charlie";
            dog1.Species = "Canine";
            dog1.Breed = "Labrador";

            dog1.DIsplayAnimal();

            dog1.DisplayDog();
        }
    }
