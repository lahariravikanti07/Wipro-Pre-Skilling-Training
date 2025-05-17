using System;

namespace AnimalBehavior
{
    // 1. Abstract class Animal
    abstract class Animal
    {
        // Abstract method
        public abstract void MakeSound();

        // Concrete method
        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }

    // 2. Dog class
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Barks");
        }
    }

    // 2. Cat class
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meows");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 3. Create Animal references
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            // Call methods
            myDog.Eat();
            myDog.MakeSound();

            myCat.Eat();
            myCat.MakeSound();

            // Keep console open
            Console.ReadLine();
        }
    }
}
